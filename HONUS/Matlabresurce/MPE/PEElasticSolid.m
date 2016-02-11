function PEElasticSolid(L, BulkDensity, h, ResonanceFrequency)

global c
global Densityo
global Npr
global Density1
global DensityA
global HeatRatio
global Merit
global SolidPara

Density1=BulkDensity;

ResonanceFrequencyMat=ResonanceFrequency*ones(100,50);

ResonError=10^10000000;
for ii=1:1:100
    tEm=ii*10000;
    for tPRatio=0.01:0.01:0.49
        for tLFactor=0.01:0.01:1
            E1=tEm.*(1+j.*tLFactor);
            A= tPRatio.*E1./(1+tPRatio)./(1-2.*tPRatio);               % Lame constant  
            N=E1./2./(1+tPRatio);                                  % shear modulus
            Kc=A+2.*N;
            ResonanceFrequency_temp=1./(4.*L)*real(sqrt(Kc./Density1));
            ResonFreErrorTemp=abs(ResonanceFrequency_temp - ResonanceFrequency).^2;
%     [C I]=min(ResonFreErrorTemp);
%     [C2 I2]=min(C);
%     tPRatio=I2*0.01;
%     tLFactor=I(I2)*0.01;
            if (ResonFreErrorTemp < ResonError)
                OptEm=tEm;
                OptPRatio=tPRatio;
                OptLFactor=tLFactor;
                ResonError=ResonFreErrorTemp;    
            end
        end
    end
end

SolidPara=[OptEm OptLFactor OptPRatio];