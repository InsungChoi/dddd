%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%                                                              %
%                  Transfer Matrix for Panel                   %
%                                                              %
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

function TMPanel(freq,theta,L, Density, Em, PRatio)

global TM;
global c 

omega = 2*pi*freq;
k = omega/c;
kx = k*sin(theta);
ky = k*cos(theta);


D=Em.*L^3./(12.*(1-PRatio.^2));		    % flexural stiffness of panel
ms=Density.*L;						% surface density of panel

TM(1,1)=1;
if omega==0
    TM(1,2)=0;
else
    TM(1,2)=1/(j.*omega).*(D.*kx^4-omega^2.*ms);
end
TM(2,1)=0;
TM(2,2)=1;



