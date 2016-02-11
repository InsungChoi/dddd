%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%                                                              %
%        Transfer Matrix for Elastic Porous Material           %
%                                                              %
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

function TMElastic(freq,theta,L,BulkDensity,FlowRes,SFactor,h,VCL,TCL,Em,LFactor,PRatio)

global TM;
global c Densityo HeatRatio Npr ItaAir P0

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
k1y = sqrt(k1^2-kx^2);
k2y = sqrt(k2^2-kx^2);
kty = sqrt(kt^2-kx^2);

b1 = a1-a2*k1^2;
b2 = a1-a2*k2^2;

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

BM(1,1)=j*kx*exp(-j*k1y*L)/k1^2;
BM(1,2)=j*kx*exp(j*k1y*L)/k1^2;
BM(1,3)=j*kx*exp(-j*k2y*L)/k2^2;
BM(1,4)=j*kx*exp(j*k2y*L)/k2^2;
BM(1,5)=-j*kty*exp(-j*kty*L)/kt^2;
BM(1,6)=j*kty*exp(j*kty*L)/kt^2;

BM(2,1)=j*k1y*exp(-j*k1y*L)/k1^2;
BM(2,2)=-j*k1y*exp(j*k1y*L)/k1^2;
BM(2,3)=j*k2y*exp(-j*k2y*L)/k2^2;
BM(2,4)=-j*k2y*exp(j*k2y*L)/k2^2;
BM(2,5)=j*kx*exp(-j*kty*L)/kt^2;
BM(2,6)=j*kx*exp(j*kty*L)/kt^2;

BM(3,1)=j*b1*k1y*exp(-j*k1y*L)/k1^2;
BM(3,2)=-j*b1*k1y*exp(j*k1y*L)/k1^2;
BM(3,3)=j*b2*k2y*exp(-j*k2y*L)/k2^2;
BM(3,4)=-j*b2*k2y*exp(j*k2y*L)/k2^2;
BM(3,5)=j*g*kx*exp(-j*kty*L)/kt^2;
BM(3,6)=j*g*kx*exp(j*kty*L)/kt^2;

BM(4,1)=(2*N*k1y^2/k1^2+A+b1*Q)*exp(-j*k1y*L);
BM(4,2)=(2*N*k1y^2/k1^2+A+b1*Q)*exp(j*k1y*L);
BM(4,3)=(2*N*k2y^2/k2^2+A+b2*Q)*exp(-j*k2y*L);
BM(4,4)=(2*N*k2y^2/k2^2+A+b2*Q)*exp(j*k2y*L);
BM(4,5)=2*N*kx*kty/kt^2*exp(-j*kty*L);
BM(4,6)=-2*N*kx*kty/kt^2*exp(j*kty*L);

BM(5,1)=(Q+b1*R)*exp(-j*k1y*L);
BM(5,2)=(Q+b1*R)*exp(j*k1y*L);
BM(5,3)=(Q+b2*R)*exp(-j*k2y*L);
BM(5,4)=(Q+b2*R)*exp(j*k2y*L);
BM(5,5)=0;
BM(5,6)=0;

BM(6,1)=2*N*kx*k1y/k1^2*exp(-j*k1y*L);
BM(6,2)=-2*N*kx*k1y/k1^2*exp(j*k1y*L);
BM(6,3)=2*N*kx*k2y/k2^2*exp(-j*k2y*L);
BM(6,4)=-2*N*kx*k2y/k2^2*exp(j*k2y*L);
BM(6,5)=N*(kx^2-kty^2)/kt^2*exp(-j*kty*L);
BM(6,6)=N*(kx^2-kty^2)/kt^2*exp(j*kty*L);

CM=AM*inv(BM);

for i=1:4;
	for k=1:4;
		DM(i,k)=CM(i+1,k+1)-CM(i+1,1)*CM(6,k+1)/CM(6,1);
	end
end

%U1 = (1-h)/h*DM(4,2)-1/h*DM(4,1);
%U2 = (1-h)/h*DM(4,3)+DM(4,4);
%U3 = -DM(4,2)/(j*omega*h^2);
%U4 = j*omega*((1-h)*(DM(1,1)-DM(2,2))-(1-h)^2/h*DM(1,2));
%U5 = -j*omega*((1-h)^2*DM(1,3)+h*(1-h)*(DM(1,3)+DM(1,4))+h^2*DM(2,4));
%U6 = (1-h)/h*DM(1,2)+DM(2,2);
%U7 = ((1-h)/h*DM(4,3)+DM(4,4)-DM(3,3)-h/(1-h)*DM(3,4))/(DM(3,1)/(1-h)-1/h*(DM(4,1)+DM(3,2))+(1-h)/(h^2)*DM(4,2));
%U8 = (DM(3,2)/(h*(1-h))-DM(4,2)/(h^2))/(j*omega*(DM(3,1)/(1-h)-1/h*(DM(4,1)+DM(3,2))+(1-h)/(h^2)*DM(4,2)));

%TElastic(1,1)=U2-U1*U7;
%TElastic(1,2)=U3-U8*U1;
%TElastic(2,1)=U5-U7*U4;
%TElastic(2,2)=U6-U8*U4;

Q1=-(h*DM(3,1)-(1-h)*DM(4,1))/(h*DM(3,2)-(1-h)*DM(4,2));
Q2=(h*(1-h)*(DM(4,4)-DM(3,3))+(1-h)^2*DM(4,3)-h^2*DM(3,4))/((1-h)*DM(4,2)-h*DM(3,2));
Q3=j*omega*((1-h)*(DM(1,1)+Q1*DM(1,2))+h*(DM(2,1)+Q1*DM(2,2)));
Q4=j*omega*((1-h)*(Q2*DM(1,2)-(1-h)*DM(1,3)-h*DM(1,4))+h*(Q2*DM(2,2)-(1-h)*DM(2,3)-h*DM(2,4)));

TM(1,1)=DM(4,4)+(1-h)/h*DM(4,3)+(Q1/(1-h+h*Q1)-1/h)*Q2*DM(4,2)+(Q2/(1-h+h*Q1))*DM(4,1);
TM(1,2)=-(DM(4,1)+Q1*DM(4,2))/(j*omega*h*(1-h+h*Q1));
TM(2,1)=Q4-h*Q2*Q3/(1-h+h*Q1);
TM(2,2)=Q3/(j*omega*(1-h+h*Q1));
