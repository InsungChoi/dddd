%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%                                                              %
%        Transfer Matrix for Panel-Elastic-Panel Foam  BB      %
%                                                              %
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

function TMPanelElasticPanel(freq,theta,hp1, Densityp1, Ep1, PRatiop1, L, BulkDensity, FlowRes, SFactor, h, VCL, TCL, Em, PRatio, LFactor, hp2, Densityp2, Ep2, PRatiop2)
% This is a function program to define the transfer matrix for panel-foam-panel alyer

% Definition of global variables
global TM;
global c Densityo HeatRatio Npr ItaAir

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

ms1=Densityp1*hp1;					% surface density of front panel
ms2=Densityp2*hp2;					% surface density of rear panel
D1=Ep1*hp1^3/(12*(1-PRatiop1^2));	% flexural stiffness of front panel
D2=Ep2*hp2^3/(12*(1-PRatiop2^2));	% flexural stiffness of rear panel
Dp1=Ep1*hp1/(1-PRatiop1^2);			% longitudinal stiffness of front panel
Dp2=Ep2*hp2/(1-PRatiop2^2);			% longitudinal stiffness of rear panel

Zmt1=j*(omega*ms1-D1*kx^4/omega);	% mechanical impedance of front panel for transverse motion
Zmt2=j*(omega*ms2-D2*kx^4/omega);	% mechanical impedance of rear panel for transverse motion

Zmp1=j*(omega*ms1-Dp1*kx^2/omega);	% mechanical impedance of front panel for longitudinal motion
Zmp2=j*(omega*ms2-Dp2*kx^2/omega);	% mechanical impedance of rear panel for longitudinal motion

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

%Transfer Matrix for panel-foam-panel configuration(Tpfp)

Zmt1=j*(omega*ms1-D1*kx^4/omega);
Zmt2=j*(omega*ms2-D2*kx^4/omega);

Zmp1=j*(omega*ms1-Dp1*kx^2/omega);
Zmp2=j*(omega*ms2-Dp2*kx^2/omega);
	
q1=-(CM(2,1)-CM(3,1))/(CM(2,5)-CM(3,5));
q2=-(CM(2,2)+CM(2,3)-CM(3,2)-CM(3,3))/(CM(2,5)-CM(3,5));
q3=-(CM(2,4)-CM(3,4))/(CM(2,5)-CM(3,5));
q4=-(CM(2,6)-CM(3,6))/(CM(2,5)-CM(3,5));

EM(1,1)=CM(1,1)+CM(1,5)*q1;
EM(1,2)=(CM(1,2)+CM(1,3)+q2*CM(1,5))/j/omega;
EM(1,3)=CM(1,4)+CM(1,5)*q3;
EM(1,4)=CM(1,6)+CM(1,5)*q4;
	
EM(2,1)=j*omega*(CM(1,2)+CM(2,5)*q1);
EM(2,2)=CM(2,2)+CM(2,3)+q2*CM(2,5);
EM(2,3)=j*omega*(CM(2,4)+CM(2,5)*q3);
EM(2,4)=j*omega*(CM(2,6)+CM(2,5)*q4);
	
EM(3,1)=CM(4,1)+CM(4,5)*q1;
EM(3,2)=(CM(4,2)+CM(4,3)+CM(4,5)*q2)/j/omega;
EM(3,3)=CM(4,4)+CM(4,5)*q3;
EM(3,4)=CM(4,6)+CM(4,5)*q4;
	
EM(4,1)=CM(5,1)+CM(5,5)*q1;
EM(4,2)=(CM(5,2)+CM(5,3)+CM(5,5)*q2)/j/omega;
EM(4,3)=CM(5,4)+CM(5,5)*q3;
EM(4,4)=CM(5,6)+CM(5,5)*q4;
	
EM(5,1)=CM(6,1)+CM(6,5)*q1;
EM(5,2)=(CM(6,2)+CM(6,3)+CM(6,5)*q2)/j/omega;
EM(5,3)=CM(6,4)+CM(6,5)*q3;
EM(5,4)=CM(6,6)+CM(6,5)*q4;
	
FM(1,1)=-kx*hp2/2/omega*EM(1,1)+EM(1,2);
FM(1,2)=EM(1,3);
FM(1,3)=-EM(1,1)/(j*omega*Zmp2)+EM(1,4);

FM(2,1)=-kx*hp2/2/omega*EM(2,1)+EM(2,2);
FM(2,2)=EM(2,3);
FM(2,3)=-EM(2,1)/(j*omega*Zmp2)+EM(2,4);
		
FM(3,1)=-kx*hp2/2/omega*EM(3,1)+EM(3,2);
FM(3,2)=EM(3,3);
FM(3,3)=-EM(3,1)/(j*omega*Zmp2)+EM(3,4);

FM(4,1)=-kx*hp2/2/omega*EM(4,1)+EM(4,2);
FM(4,2)=EM(4,3);
FM(4,3)=-EM(4,1)/(j*omega*Zmp2)+EM(4,4);
	
FM(5,1)=-kx*hp2/2/omega*EM(5,1)+EM(5,2);
FM(5,2)=EM(5,3);
FM(5,3)=-EM(5,1)/(j*omega*Zmp2)+EM(5,4);

r1=-(FM(1,1)-FM(5,1)/(j*omega*Zmp1)-kx*hp1*FM(2,1)/2/omega)/(FM(1,2)-FM(5,2)/(j*omega*Zmp1)-kx*hp1*FM(2,2)/2/omega);
r2=-(FM(1,3)-FM(5,3)/(j*omega*Zmp1)-kx*hp1*FM(2,3)/2/omega)/(FM(1,2)-FM(5,2)/(j*omega*Zmp1)-kx*hp1*FM(2,2)/2/omega);
r3=Zmt1*FM(2,1)-FM(3,1)-FM(4,1)+j*kx*hp1/2*FM(5,1);
r4=Zmt1*FM(2,2)-FM(3,2)-FM(4,2)+j*kx*hp1/2*FM(5,2);
r5=Zmt1*FM(2,3)-FM(3,3)-FM(4,3)+j*kx*hp1/2*FM(5,3);	
r6=-kx*hp2/2/omega*q1+q2/j/omega+r1*q3;
r7=-q1/(j*omega*Zmp2)+r2*q3+q4;
r8=-1/(r2+r7+j*kx*hp2/2);
r9=-(Zmt2+r1+r6)/(r2+r7+j*kx*hp2/2);
	
TM(1,1)=r8*(r5+r2*r4);
TM(1,2)=r3+r1*r4+r9*(r5+r2*r4);
TM(2,1)=r8*(F(2,3)+F(2,2)*r2);
TM(2,2)=F(2,1)+F(2,2)*r1+r9*(F(2,3)+F(2,2)*r2);
  
