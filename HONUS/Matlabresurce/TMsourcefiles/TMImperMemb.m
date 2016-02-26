%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%                                                              %
%        Transfer Matrix for Impermeable Membrane              %
%                                                              %
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

function TM = TMImperMemb(c,Density,freq,L,theta)

TM = eye(2);
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
end
