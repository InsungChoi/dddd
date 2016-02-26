%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%                                                              %
%        Transfer Matrix for Rigid Porous Material             %
%                                                              %
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


function TM = TMRigid(BulkDensity,c,Densityo,FlowRes,freq,h,HeatRatio,ItaAir,L,Npr,P0,SFactor,TCL,theta,VCL)

TM = eye(2);

%Constant and variable definition
omega = 2*pi*freq;
k = omega/c;
kx = k*sin(theta);
%ky = k*cos(theta); %% unused variable

c1=1/VCL*sqrt(8*SFactor*ItaAir/(h*FlowRes));
c2=1/TCL*sqrt(8*SFactor*ItaAir/(h*FlowRes));

s1 = c1*sqrt(8*omega*SFactor*Densityo/(h*FlowRes))*sqrt(-1i);
s2 = 1/c2*sqrt(Npr)*sqrt(8*omega*SFactor*Densityo/(h*FlowRes))*sqrt(-1i);

Gc1 = -(s1*besselj(1,s1))/(besselj(0,s1))/(1-2*besselj(1,s1)/(s1*besselj(0,s1)));
Gc2 = -(s2*besselj(1,s2))/(besselj(0,s2))/(1-2*besselj(1,s2)/(s2*besselj(0,s2)));

b = FlowRes*h^2*Gc1/4;
Density1=BulkDensity;
Density2=Densityo*h;  
Densitya = Density2*(SFactor-1);
Density11s =  Density1+Densitya+b/(1i*omega);
Density12s = -Densitya-b/(1i*omega);
Density22s =  Density2+Densitya+b/(1i*omega);

Kf = HeatRatio*P0/(HeatRatio-(HeatRatio-1)/(1+(FlowRes*h)/(1i*Npr*omega*Densityo*SFactor)*Gc2));

P = (1-h)^2/h*Kf;
Q = (1-h)*Kf;
R = h*Kf;

a = (Density12s*Q-Density11s*R)/(Density12s*R-Density22s*Q);
kp = sqrt(((omega^2)*((Density12s)^2-Density11s*Density22s))/(2*Density12s*Q-Density22s*P-Density11s*R));
kpy = sqrt(kp^2-kx^2);

%% Elements of Transfer Matrix
TM(1,1) = cos(kpy*L);
TM(1,2) = 1i*(R*a+Q)/(omega*h*(1+(a-1)*h))*(kp^2/kpy)*sin(kpy*L);
TM(2,1) = 1i*(omega*h*(1+(a-1)*h)/(R*a+Q))*(kpy/kp^2)*sin(kpy*L);
TM(2,2) = cos(kpy*L);

