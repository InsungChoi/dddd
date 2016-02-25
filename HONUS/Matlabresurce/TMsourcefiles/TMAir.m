%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%                                                           %
%           Transfer Matrix for Air Layer                   %
%                                                           %
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


function TMAir(freq,theta,L)

global TM;
global c Densityo 

omega = 2*pi*freq;
k = omega/c;
kx = k*sin(theta);
ky = k*cos(theta);


TM(1,1)=cos(ky*L);
TM(1,2)=1i*Densityo*c*sin(ky*L)/cos(theta);
TM(2,1)=1i*cos(theta)*sin(ky*L)/(Densityo*c);
TM(2,2)=cos(ky*L);
