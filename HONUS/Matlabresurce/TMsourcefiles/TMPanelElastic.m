%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%                                                              %
%        Transfer Matrix for Panel-Elastic Foam  BU            %
%                                                              %
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

function TMPanelElastic(freq,theta,hp, Densityp, Ep, PRatiop, L, BulkDensity, FlowRes, SFactor, h, VCL, TCL, Em, PRatio, LFactor)
% This is a function program to define the transfer matrix for panel-foam layer

% Definition of global variables
global TM;
global c Densityo HeatRatio Npr ItaAir 
			    	    % Prandtl number
E1=Em*(1+1i*LFactor);	            % elastic Young's modulus of solid frame
E0=Densityo*c^2;				    % elastic constant of fluid
Density2=h*Densityo;				% density of fluid phase
Densitya=Density2*(SFactor-1);	    % mass coupling factor
d=L;         						% thickness of panle-foam layer

%Constant and variable definition
omega = 2*pi*freq;
k = omega/c;
kx = k*sin(theta);
ky = k*cos(theta);

c1=1/VCL*sqrt(8*SFactor*ItaAir/(h*FlowRes));
c2=1/TCL*sqrt(8*SFactor*ItaAir/(h*FlowRes));
                                       
s1 = c1*sqrt(8*omega*SFactor*Densityo/(h*FlowRes))*sqrt(-1i);
s2 = 1/c2*sqrt(Npr)*sqrt(8*omega*SFactor*Densityo/(h*FlowRes))*sqrt(-1i);

Gc1 = -(s1*besselj(1,s1))/(besselj(0,s1))/(1-2*besselj(1,s1)/(s1*besselj(0,s1)));

b = FlowRes*h^2*Gc1/4;
        
E0=Densityo*(c^2);
E1=Em*(1+1i*LFactor);
E2=E0/(1+((2*(HeatRatio-1)/s2)*besselj(1,s2)/besselj(0,s2)));
    
A= PRatio*E1/(1+PRatio)/(1-2*PRatio);               % Lame constant
N = E1/2/(1+PRatio);                                % Shear modulus

Density1=BulkDensity;
Density2=h*Densityo;
DensityA=Density2*(SFactor-1);                      % mass coupling factor
Density11s=Density1+DensityA+b/(1i*omega);
Density12s=-DensityA-b/(1i*omega);
Density22s=Density2+DensityA+b/(1i*omega);
g = -Density12s/Density22s;
    
P = A+2*N;
Q = (1-h)*E2;
R = h*E2;

a1 = (Density11s*R-Density12s*Q)/(Density22s*Q-Density12s*R);
a2 = (P*R-Q^2)/(omega^2*(Density22s*Q-Density12s*R));
A1 = omega^2*(Density11s*R-2*Density12s*Q+Density22s*P)/(P*R-Q^2);
A2 = omega^4*(Density11s*Density22s-Density12s^2)/(P*R-Q^2);
k1 = sqrt((A1+sqrt(A1^2-4*A2))/2.0);
k2 = sqrt((A1-sqrt(A1^2-4*A2))/2.0);
kt = sqrt(omega^2/N*(Density11s-Density12s^2/Density22s));
k1y = sqrt(k1^2-kx^2);
k2y = sqrt(k2^2-kx^2);
kty = sqrt(kt^2-kx^2);

b1 = a1-a2*k1^2;
b2 = a1-a2*k2^2;

ms=Densityp*hp;					% surface density of panel
D=Ep*hp^3/(12*(1-PRatiop^2));	% flexural stiffness of panel(per unit width)
Dp=Ep*hp/(1-PRatiop^2);			% longitudinal stiffness of panel(per unit width)

Zmt=1i*(omega*ms-D*kx^4/omega);	% mechanical impedance of panel for transverse motion
Zmp=1i*(omega*ms-Dp*kx^2/omega);	% mechanical impedance of panel for longitudinal motion

%Transfer Matrix for the Porous Layer

AM(1,1)=1i*kx/k1^2;
AM(1,2)=1i*kx/k1^2;
AM(1,3)=1i*kx/k2^2;
AM(1,4)=1i*kx/k2^2;
AM(1,5)=-1i*kty/kt^2;
AM(1,6)=1i*kty/kt^2;

AM(2,1)=1i*k1y/k1^2;
AM(2,2)=-1i*k1y/k1^2;
AM(2,3)=1i*k2y/k2^2;
AM(2,4)=-1i*k2y/k2^2;
AM(2,5)=1i*kx/kt^2;
AM(2,6)=1i*kx/kt^2;

AM(3,1)=1i*b1*k1y/k1^2;
AM(3,2)=-1i*b1*k1y/k1^2;
AM(3,3)=1i*b2*k2y/k2^2;
AM(3,4)=-1i*b2*k2y/k2^2;
AM(3,5)=1i*g*kx/kt^2;
AM(3,6)=1i*g*kx/kt^2;

AM(4,1)=2*N*k1y^2/k1^2+A+b1*Q;
AM(4,2)=2*N*k1y^2/k1^2+A+b1*Q;
AM(4,3)=2*N*k2y^2/k2^2+A+b2*Q;
AM(4,4)=2*N*k2y^2/k2^2+A+b2*Q;
AM(4,5)=2*N*kx*kty/kt^2;
AM(4,6)=-2*N*kx*kty/kt^2;

AM(5,1)=Q+b1*R;
AM(5,2)=Q+b1*R;
AM(5,3)=Q+b2*R;
AM(5,4)=Q+b2*R;
AM(5,5)=0;
AM(5,6)=0;

AM(6,1)=2*N*kx*k1y/k1^2;
AM(6,2)=-2*N*kx*k1y/k1^2;
AM(6,3)=2*N*kx*k2y/k2^2;
AM(6,4)=-2*N*kx*k2y/k2^2;
AM(6,5)=N*(kx^2-kty^2)/kt^2;
AM(6,6)=N*(kx^2-kty^2)/kt^2;

BM(1,1)=1i*kx*exp(-1i*k1y*d)/k1^2;
BM(1,2)=1i*kx*exp(1i*k1y*d)/k1^2;
BM(1,3)=1i*kx*exp(-1i*k2y*d)/k2^2;
BM(1,4)=1i*kx*exp(1i*k2y*d)/k2^2;
BM(1,5)=-1i*kty*exp(-1i*kty*d)/kt^2;
BM(1,6)=1i*kty*exp(1i*kty*d)/kt^2;

BM(2,1)=1i*k1y*exp(-1i*k1y*d)/k1^2;
BM(2,2)=-1i*k1y*exp(1i*k1y*d)/k1^2;
BM(2,3)=1i*k2y*exp(-1i*k2y*d)/k2^2;
BM(2,4)=-1i*k2y*exp(1i*k2y*d)/k2^2;
BM(2,5)=1i*kx*exp(-1i*kty*d)/kt^2;
BM(2,6)=1i*kx*exp(1i*kty*d)/kt^2;

BM(3,1)=1i*b1*k1y*exp(-1i*k1y*d)/k1^2;
BM(3,2)=-1i*b1*k1y*exp(1i*k1y*d)/k1^2;
BM(3,3)=1i*b2*k2y*exp(-1i*k2y*d)/k2^2;
BM(3,4)=-1i*b2*k2y*exp(1i*k2y*d)/k2^2;
BM(3,5)=1i*g*kx*exp(-1i*kty*d)/kt^2;
BM(3,6)=1i*g*kx*exp(1i*kty*d)/kt^2;

BM(4,1)=(2*N*k1y^2/k1^2+A+b1*Q)*exp(-1i*k1y*d);
BM(4,2)=(2*N*k1y^2/k1^2+A+b1*Q)*exp(1i*k1y*d);
BM(4,3)=(2*N*k2y^2/k2^2+A+b2*Q)*exp(-1i*k2y*d);
BM(4,4)=(2*N*k2y^2/k2^2+A+b2*Q)*exp(1i*k2y*d);
BM(4,5)=2*N*kx*kty/kt^2*exp(-1i*kty*d);
BM(4,6)=-2*N*kx*kty/kt^2*exp(1i*kty*d);

BM(5,1)=(Q+b1*R)*exp(-1i*k1y*d);
BM(5,2)=(Q+b1*R)*exp(1i*k1y*d);
BM(5,3)=(Q+b2*R)*exp(-1i*k2y*d);
BM(5,4)=(Q+b2*R)*exp(1i*k2y*d);
BM(5,5)=0;
BM(5,6)=0;

BM(6,1)=2*N*kx*k1y/k1^2*exp(-1i*k1y*d);
BM(6,2)=-2*N*kx*k1y/k1^2*exp(1i*k1y*d);
BM(6,3)=2*N*kx*k2y/k2^2*exp(-1i*k2y*d);
BM(6,4)=-2*N*kx*k2y/k2^2*exp(1i*k2y*d);
BM(6,5)=N*(kx^2-kty^2)/kt^2*exp(-1i*kty*d);
BM(6,6)=N*(kx^2-kty^2)/kt^2*exp(1i*kty*d);

CM=AM*inv(BM);

%Transfer Matrix for panel-foam configuration(Tpf)

GM(1,1)=-CM(1,1)*(CM(2,2)-CM(3,2))/(CM(2,1)-CM(3,1))+CM(1,2);
GM(1,2)=-CM(1,1)*(CM(2,3)-CM(3,3))/(CM(2,1)-CM(3,1))+CM(1,3);
GM(1,3)=-CM(1,1)*(CM(2,4)-CM(3,4))/(CM(2,1)-CM(3,1))+CM(1,4);
GM(1,4)=-CM(1,1)*(CM(2,5)-CM(3,5))/(CM(2,1)-CM(3,1))+CM(1,5);

GM(2,1)=-CM(2,1)*(CM(2,2)-CM(3,2))/(CM(2,1)-CM(3,1))+CM(2,2);
GM(2,2)=-CM(2,1)*(CM(2,3)-CM(3,3))/(CM(2,1)-CM(3,1))+CM(2,3);
GM(2,3)=-CM(2,1)*(CM(2,4)-CM(3,4))/(CM(2,1)-CM(3,1))+CM(2,4);
GM(2,4)=-CM(2,1)*(CM(2,5)-CM(3,5))/(CM(2,1)-CM(3,1))+CM(2,5);

GM(3,1)=-CM(4,1)*(CM(2,2)-CM(3,2))/(CM(2,1)-CM(3,1))+CM(4,2);
GM(3,2)=-CM(4,1)*(CM(2,3)-CM(3,3))/(CM(2,1)-CM(3,1))+CM(4,3);
GM(3,3)=-CM(4,1)*(CM(2,4)-CM(3,4))/(CM(2,1)-CM(3,1))+CM(4,4);
GM(3,4)=-CM(4,1)*(CM(2,5)-CM(3,5))/(CM(2,1)-CM(3,1))+CM(4,5);

GM(4,1)=-CM(5,1)*(CM(2,2)-CM(3,2))/(CM(2,1)-CM(3,1))+CM(5,2);
GM(4,2)=-CM(5,1)*(CM(2,3)-CM(3,3))/(CM(2,1)-CM(3,1))+CM(5,3);
GM(4,3)=-CM(5,1)*(CM(2,4)-CM(3,4))/(CM(2,1)-CM(3,1))+CM(5,4);
GM(4,4)=-CM(5,1)*(CM(2,5)-CM(3,5))/(CM(2,1)-CM(3,1))+CM(5,5);

GM(5,1)=-CM(6,1)*(CM(2,2)-CM(3,2))/(CM(2,1)-CM(3,1))+CM(6,2);
GM(5,2)=-CM(6,1)*(CM(2,3)-CM(3,3))/(CM(2,1)-CM(3,1))+CM(6,3);
GM(5,3)=-CM(6,1)*(CM(2,4)-CM(3,4))/(CM(2,1)-CM(3,1))+CM(6,4);
GM(5,4)=-CM(6,1)*(CM(2,5)-CM(3,5))/(CM(2,1)-CM(3,1))+CM(6,5);

HM(1,1)=GM(1,1);
HM(1,2)=GM(1,2);
HM(1,3)=-(1-h)*GM(1,3)-h*GM(1,4);

HM(2,1)=1i*omega*GM(2,1);
HM(2,2)=1i*omega*GM(2,2);
HM(2,3)=-1i*omega*((1-h)*GM(2,3)+h*GM(2,4));

HM(3,1)=GM(3,1);
HM(3,2)=GM(3,2);
HM(3,3)=-(1-h)*GM(3,3)-h*GM(3,4);

HM(4,1)=GM(4,1);
HM(4,2)=GM(4,2);
HM(4,3)=-(1-h)*GM(4,3)-h*GM(4,4);

HM(5,1)=GM(5,1);
HM(5,2)=GM(5,2);
HM(5,3)=-(1-h)*GM(5,3)-h*GM(5,4);

deno=-(HM(1,2)-HM(5,2)/1i/omega/Zmp-kx*hp*HM(2,2)/2/omega);

S1=(HM(1,1)-HM(5,1)/1i/omega/Zmp-kx*hp*HM(2,1)/2/omega)/deno;
S2=(HM(1,3)-HM(5,3)/1i/omega/Zmp-kx*hp*HM(2,3)/2/omega)/deno;
S3=Zmt*HM(2,1)-HM(3,1)-HM(4,1)+1i*kx*hp*HM(5,1)/2;
S4=Zmt*HM(2,2)-HM(3,2)-HM(4,2)+1i*kx*hp*HM(5,2)/2;
S5=Zmt*HM(2,3)-HM(3,3)-HM(4,3)+1i*kx*hp*HM(5,3)/2;

TM(1,1)=S2*S4+S5-h*S2*(S1*S4+S3)/(1-h+h*S1);
TM(1,2)=(S1*S4+S3)/1i/omega/(1-h+h*S1);
TM(2,1)=HM(2,2)*S2+HM(2,3)-h*S2*(HM(2,2)*S1+HM(2,1))/(1-h+h*S1);
TM(2,2)=(HM(2,2)*S1+HM(2,1))/1i/omega/(1-h+h*S1);

