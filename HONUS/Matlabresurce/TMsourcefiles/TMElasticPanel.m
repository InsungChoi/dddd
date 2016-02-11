%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%                                                              %
%        Transfer Matrix for Elastic-Panel Foam  UB            %
%                                                              %
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

function TMElasticPanel(freq,theta,L, BulkDensity, FlowRes, SFactor, h, VCL, TCL, Em, PRatio, LFactor, hp, Densityp, Ep, PRatiop)
%This is a function program to define the transfer matrix for foam-panel layer

global TM;
global c Densityo HeatRatio Npr ItaAir P0

E1=Em*(1+j*LFactor);	            % elastic Young's modulus of solid frame
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
                                       
s1 = c1*sqrt(8*omega*SFactor*Densityo/(h*FlowRes))*sqrt(-j);
s2 = 1/c2*sqrt(Npr)*sqrt(8*omega*SFactor*Densityo/(h*FlowRes))*sqrt(-j);

Gc1 = -(s1*besselj(1,s1))/(besselj(0,s1))/(1-2*besselj(1,s1)/(s1*besselj(0,s1)));

b = FlowRes*h^2*Gc1/4;
        
E0=Densityo*(c^2);
E1=Em*(1+j*LFactor);
E2=E0/(1+((2*(HeatRatio-1)/s2)*besselj(1,s2)/besselj(0,s2)));
    
A= PRatio*E1/(1+PRatio)/(1-2*PRatio);               % Lame constant
N = E1/2/(1+PRatio);                                % Shear modulus

Density1=BulkDensity;
Density2=h*Densityo;
DensityA=Density2*(SFactor-1);                      % mass coupling factor
Density11s=Density1+DensityA+b/(j*omega);
Density12s=-DensityA-b/(j*omega);
Density22s=Density2+DensityA+b/(j*omega);
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
k1y = sqrt(k1^2-kx^2)
k2y = sqrt(k2^2-kx^2);
kty = sqrt(kt^2-kx^2);

b1 = a1-a2*k1^2;
b2 = a1-a2*k2^2;

ms=Densityp*hp;
D=Ep*hp^3/(12*(1-PRatiop^2));
Dp=Ep*hp/(1-PRatiop^2);

Zmt=j*(omega*ms-D*kx^4/omega);		% mechanical impedance for transverse motion of panel
Zmp=j*(omega*ms-Dp*kx^2/omega);		% mechanical impedance for longitudinal motion of panel

%Transfer Matrix for the Porous Layer

AM(1,1)=j*kx/k1^2;
AM(1,2)=j*kx/k1^2;
AM(1,3)=j*kx/k2^2;
AM(1,4)=j*kx/k2^2;
AM(1,5)=-j*kty/kt^2;
AM(1,6)=j*kty/kt^2;

AM(2,1)=j*k1y/k1^2;
AM(2,2)=-j*k1y/k1^2;
AM(2,3)=j*k2y/k2^2;
AM(2,4)=-j*k2y/k2^2;
AM(2,5)=j*kx/kt^2;
AM(2,6)=j*kx/kt^2;

AM(3,1)=j*b1*k1y/k1^2;
AM(3,2)=-j*b1*k1y/k1^2;
AM(3,3)=j*b2*k2y/k2^2;
AM(3,4)=-j*b2*k2y/k2^2;
AM(3,5)=j*g*kx/kt^2;
AM(3,6)=j*g*kx/kt^2;

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

BM(1,1)=j*kx*exp(-j*k1y*d)/k1^2;
BM(1,2)=j*kx*exp(j*k1y*d)/k1^2;
BM(1,3)=j*kx*exp(-j*k2y*d)/k2^2;
BM(1,4)=j*kx*exp(j*k2y*d)/k2^2;
BM(1,5)=-j*kty*exp(-j*kty*d)/kt^2;
BM(1,6)=j*kty*exp(j*kty*d)/kt^2;

BM(2,1)=j*k1y*exp(-j*k1y*d)/k1^2;
BM(2,2)=-j*k1y*exp(j*k1y*d)/k1^2;
BM(2,3)=j*k2y*exp(-j*k2y*d)/k2^2;
BM(2,4)=-j*k2y*exp(j*k2y*d)/k2^2;
BM(2,5)=j*kx*exp(-j*kty*d)/kt^2;
BM(2,6)=j*kx*exp(j*kty*d)/kt^2;

BM(3,1)=j*b1*k1y*exp(-j*k1y*d)/k1^2;
BM(3,2)=-j*b1*k1y*exp(j*k1y*d)/k1^2;
BM(3,3)=j*b2*k2y*exp(-j*k2y*d)/k2^2;
BM(3,4)=-j*b2*k2y*exp(j*k2y*d)/k2^2;
BM(3,5)=j*g*kx*exp(-j*kty*d)/kt^2;
BM(3,6)=j*g*kx*exp(j*kty*d)/kt^2;

BM(4,1)=(2*N*k1y^2/k1^2+A+b1*Q)*exp(-j*k1y*d);
BM(4,2)=(2*N*k1y^2/k1^2+A+b1*Q)*exp(j*k1y*d);
BM(4,3)=(2*N*k2y^2/k2^2+A+b2*Q)*exp(-j*k2y*d);
BM(4,4)=(2*N*k2y^2/k2^2+A+b2*Q)*exp(j*k2y*d);
BM(4,5)=2*N*kx*kty/kt^2*exp(-j*kty*d);
BM(4,6)=-2*N*kx*kty/kt^2*exp(j*kty*d);

BM(5,1)=(Q+b1*R)*exp(-j*k1y*d);
BM(5,2)=(Q+b1*R)*exp(j*k1y*d);
BM(5,3)=(Q+b2*R)*exp(-j*k2y*d);
BM(5,4)=(Q+b2*R)*exp(j*k2y*d);
BM(5,5)=0;
BM(5,6)=0;

BM(6,1)=2*N*kx*k1y/k1^2*exp(-j*k1y*d);
BM(6,2)=-2*N*kx*k1y/k1^2*exp(j*k1y*d);
BM(6,3)=2*N*kx*k2y/k2^2*exp(-j*k2y*d);
BM(6,4)=-2*N*kx*k2y/k2^2*exp(j*k2y*d);
BM(6,5)=N*(kx^2-kty^2)/kt^2*exp(-j*kty*d);
BM(6,6)=N*(kx^2-kty^2)/kt^2*exp(j*kty*d);

CM=AM*inv(BM);

%Transfer Matrix for foam-panel system(Tfp)

MM(1,1)=-CM(2,5)*CM(6,1)/CM(6,5)+CM(2,1);
MM(1,2)=-CM(2,5)*(CM(6,2)+CM(6,3))/CM(6,5)+CM(2,2)+CM(2,3);
MM(1,3)=-CM(2,5)*CM(6,4)/CM(6,5)+CM(2,4);
MM(1,4)=-CM(2,5)*CM(6,6)/CM(6,5)+CM(2,6);

MM(2,1)=-CM(3,5)*CM(6,1)/CM(6,5)+CM(3,1);
MM(2,2)=-CM(3,5)*(CM(6,2)+CM(6,3))/CM(6,5)+CM(3,2)+CM(3,3);
MM(2,3)=-CM(3,5)*CM(6,4)/CM(6,5)+CM(3,4);
MM(2,4)=-CM(3,5)*CM(6,6)/CM(6,5)+CM(3,6);

MM(3,1)=-CM(4,5)*CM(6,1)/CM(6,5)+CM(4,1);
MM(3,2)=-CM(4,5)*(CM(6,2)+CM(6,3))/CM(6,5)+CM(4,2)+CM(4,3);
MM(3,3)=-CM(4,5)*CM(6,4)/CM(6,5)+CM(4,4);
MM(3,4)=-CM(4,5)*CM(6,6)/CM(6,5)+CM(4,6);

MM(4,1)=-CM(5,5)*CM(6,1)/CM(6,5)+CM(5,1);
MM(4,2)=-CM(5,5)*(CM(6,2)+CM(6,3))/CM(6,5)+CM(5,2)+CM(5,3);
MM(4,3)=-CM(5,5)*CM(6,4)/CM(6,5)+CM(5,4);
MM(4,4)=-CM(5,5)*CM(6,6)/CM(6,5)+CM(5,6);

NM(1,1)=-kx*hp/2/omega*MM(1,1)+MM(1,2)/j/omega;
NM(1,2)=MM(1,3);
NM(1,3)=-MM(1,1)/j/omega/Zmp+MM(1,4);

NM(2,1)=-kx*hp/2/omega*MM(2,1)+MM(2,2)/j/omega;
NM(2,2)=MM(2,3);
NM(2,3)=-MM(2,1)/j/omega/Zmp+MM(2,4);

NM(3,1)=-kx*hp/2/omega*MM(3,1)+MM(3,2)/j/omega;
NM(3,2)=MM(3,3);
NM(3,3)=-MM(3,1)/j/omega/Zmp+MM(3,4);

NM(4,1)=-kx*hp/2/omega*MM(4,1)+MM(4,2)/j/omega;
NM(4,2)=MM(4,3);
NM(4,3)=-MM(4,1)/j/omega/Zmp+MM(4,4);

denofp=-(NM(4,2)/h-NM(3,2)/(1-h));

U1=(NM(4,1)/h-NM(3,1)/(1-h))/denofp;
U2=(NM(4,3)/h-NM(3,3)/(1-h))/denofp;
U3=j*omega*((1-h)*(NM(1,1)+NM(1,2)*U1)+h*(NM(2,1)+NM(2,2)*U1));
U4=j*omega*((1-h)*(NM(1,3)+NM(1,2)*U2)+h*(NM(2,3)+NM(2,2)*U2));
U5=(kx*hp/2/omega*CM(6,1)-(CM(6,2)+CM(6,3))/j/omega-U1*CM(6,4))/CM(6,5);
U6=(CM(6,1)/j/omega/Zmp-U2*CM(6,4)-CM(6,6))/CM(6,5);

TM(1,1)=(NM(4,2)*U2+NM(4,3))/h/(U2+U6+j*kx*hp/2);
TM(1,2)=1/h*(-NM(4,1)-NM(4,2)*U1+(NM(4,2)*U2+NM(4,3))*(U1+U5+Zmt)/(U2+U6+j*kx*hp/2));
TM(2,1)=-U4/(U2+U6+j*kx*hp/2);
TM(2,2)=U3-U4*(U1+U5+Zmt)/(U2+U6+j*kx*hp/2);

