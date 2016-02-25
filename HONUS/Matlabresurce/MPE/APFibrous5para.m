function APFibrous5para(L, FlowRes, SFactor, h, c1, c2, fre)
% PEFibrous5para(L, BulkDensity,FlowRes, SFactor, h, c1, c2, fre, RowSizeOfPara, MeasuredAbsorptionMat)
    
    global ItaAir 
    global P0 
    global Z0 

    global B 
    global Densityo
    global Npr
    global Density1
    global HeatRatio
    global APFibrous

    omega=2*pi.*fre;
           
    VCL=1./c1*sqrt(8.*SFactor.*ItaAir./(h.*FlowRes));
    TCL=1./c2*sqrt(8.*SFactor.*ItaAir./(h.*FlowRes));
                       
    H = ((FlowRes.*VCL.*h).^2)./(4.*(SFactor.^2).*ItaAir.*Densityo);
    HP = 16.*ItaAir./(((Npr.*TCL).^2).*Densityo);
    
    DySFactor = SFactor.*(1-1i*h.*FlowRes./(omega.*Densityo.*SFactor).*sqrt(1+1i*omega./H));
    Bterm = ((h./DySFactor-1).^2)./(h.*Density1+(h.^2).*Densityo.*(1-1./DySFactor));
    DyDensity = (1./(Densityo.*DySFactor) + B.*Bterm).^(-1);
    Kf = HeatRatio.*P0./(HeatRatio-(HeatRatio-1).*(1-1i*HP./(2.*omega).*sqrt(1+1i*omega./HP)).^(-1));
    
    Z = -1i*1./(h.*Z0).*sqrt(DyDensity.*Kf).*cot(omega.*L.*sqrt(DyDensity./Kf));
    Ref=(Z-1)./(Z+1);
    APFibrous=1-(abs(Ref)).^2;
         
    


