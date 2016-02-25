%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%                                                              %
%        Transfer Matrix for Impermeable Membrane              %
%                                                              %
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

function TMImperMemb(freq,theta,L,Density)

global TM;
global c 
%Constant and variable definition
omega = 2*pi*freq;
k = omega/c;
kx = k*sin(theta);
ky = k*cos(theta);

ms=Density*L;

Zmp=1i*omega*ms;

TM(1,1)=1;
TM(1,2)=Zmp;
TM(2,1)=0;
TM(2,2)=1;
