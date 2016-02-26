%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%                                                              %
%        Transfer Matrix for Permeable Membrane                %
%                                                              %
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

function TM = TMperMemb(Density,FlowRes,freq,L)

TM = eye(2);
%Constant and variable definition
omega = 2*pi*freq;
%k = omega/c; %%unused variable
%kx = k*sin(theta); %%unused variable
%ky = k*cos(theta); %%unused variable

ms=Density*L;

Zmp=1i*omega*ms;

Zm=FlowRes*Zmp/(FlowRes+Zmp);

TM(1,1)=1;
TM(1,2)=Zm;
TM(2,1)=0;
TM(2,2)=1;
