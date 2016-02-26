function out = TMCalc(c,Densityo,freq,Result,theta,TotalThickness)

omega = 2*pi*freq;
k = omega/c;
kx = k*sin(theta);
ky = k*cos(theta);

R1=(Result(1,1)-Densityo*c*Result(2,1)/cos(theta))/(Result(1,1)+Densityo*c*Result(2,1)/cos(theta));
Rigid=1-abs(R1)^2;

R2=(Result(1,1)+cos(theta)/Densityo/c*Result(1,2)-Densityo*c*Result(2,1)/cos(theta)-Result(2,2))/(Result(1,1) ...
    +cos(theta)/Densityo/c*Result(1,2)+Densityo*c*Result(2,1)/cos(theta)+Result(2,2));
Anechoic=1-abs(R2)^2;

T=2*exp(1i*ky*TotalThickness)/(Result(1,1)+cos(theta)/Densityo/c*Result(1,2)+Densityo*c/cos(theta)*Result(2,1)+Result(2,2));
TL=abs(T)^2;

out = [Rigid Anechoic TL];