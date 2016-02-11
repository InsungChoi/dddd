%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%                                                              %
%        Transfer Matrix for Permeable Membrane                %
%                                                              %
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

function TMperMemb(freq,theta, L, Density, FlowRes)

global TM;
global c Densityo HeatRatio Npr ItaAir P0
%Constant and variable definition
omega = 2*pi*freq;
k = omega/c;
kx = k*sin(theta);
ky = k*cos(theta);

ms=Density*L;

Zmp=j*omega*ms;

Zm=FlowRes*Zmp/(FlowRes+Zmp);

TM(1,1)=1;
TM(1,2)=Zm;
TM(2,1)=0;
TM(2,2)=1;
