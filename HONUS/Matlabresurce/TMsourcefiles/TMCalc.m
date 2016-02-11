function TMCalc(freq, theta, TotalThickness)
% elseif Travl1==7, T1=TMRigid(L1, Density1,FlowRes1,SFactor1,h1,VCL1,TCL1); thick1=L1; 
global TM;
global c Densityo HeatRatio Npr ItaAir P0
global Result;
global Rigid Anechoic TL;

omega = 2*pi*freq;
k = omega/c;
kx = k*sin(theta);
ky = k*cos(theta);

R1=(Result(1,1)-Densityo*c*Result(2,1)/cos(theta))/(Result(1,1)+Densityo*c*Result(2,1)/cos(theta));
Rigid=1-abs(R1)^2;

R2=(Result(1,1)+cos(theta)/Densityo/c*Result(1,2)-Densityo*c*Result(2,1)/cos(theta)-Result(2,2))/(Result(1,1) ...
    +cos(theta)/Densityo/c*Result(1,2)+Densityo*c*Result(2,1)/cos(theta)+Result(2,2));
Anechoic=1-abs(R2)^2;

T=2*exp(j*ky*TotalThickness)/(Result(1,1)+cos(theta)/Densityo/c*Result(1,2)+Densityo*c/cos(theta)*Result(2,1)+Result(2,2));
TL=abs(T)^2;