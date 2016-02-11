%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%                                                           %
%           Transfer Matrix for Air Layer                   %
%                                                           %
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


function TMAir(freq,theta,L)

global TM;
global c Densityo HeatRatio Npr ItaAir P0

omega = 2*pi*freq;
k = omega/c;
kx = k*sin(theta);
ky = k*cos(theta);


TM(1,1)=cos(ky*L);
TM(1,2)=j*Densityo*c*sin(ky*L)/cos(theta);
TM(2,1)=j*cos(theta)*sin(ky*L)/(Densityo*c);
TM(2,2)=cos(ky*L);
