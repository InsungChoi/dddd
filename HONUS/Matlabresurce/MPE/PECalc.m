function PECalc(PrevError)

    global Npr
    global Density1
    global HeatRatio
    global ItaAir
    global P0
    global Densityo
    global Z0
    global B

    global BulkDensity
    global Thickness

    global FlowRes
    global SFactor
    global Porosity
    global ViscousCL
    global ThermalCL

    global FlowResEst
    global SFactorEst
    global PorosityEst
    global ViscousCLEst
    global ThermalCLEst

    global freq
    global MAbsorption
    global Frequency

    global Absorption
    global SurfaceImpedance
    global TotalMerit

    tFlowRes = FlowRes
    tSFactor = SFactor
    tPorosity = Porosity

%     c1 = sqrt(8*tSFactor*ItaAir/(tPorosity*tFlowRes))/ViscousCL;
%     c2 = sqrt(8*tSFactor*ItaAir/(tPorosity*tFlowRes))/ThermalCL;
% 
%     if FlowResEst==true,
%         MeritTemp = 100;
%         for optFlowRes = 1000:100:200000
%             TotalMeritCalc(freq(1), freq(2), optFlowRes, tSFactor, tPorosity, c1, c2);
%             if (TotalMerit<MeritTemp)
%                 tFlowRes = optFlowRes;
%                 MeritTemp = TotalMerit;
%             end
%         end
%     end
% 
%     if SFactorEst==true,
%         MeritTemp = 100;
%         for optSFactor = 1:0.001:10
%             TotalMeritCalc(freq(3), freq(4), tFlowRes, optSFactor, tPorosity, c1, c2);
%             if (TotalMerit<MeritTemp)
%                 tSFactor = optSFactor;
%                 MeritTemp = TotalMerit;
%             end
%         end
%     end
% 
%     if PorosityEst==true,
%         MeritTemp = 100;
%         for optPorosity = 0.5:0.001:0.99
%             TotalMeritCalc(freq(5), freq(6), tFlowRes, tSFactor, optPorosity, c1, c2);
%             if (TotalMerit<MeritTemp)
%                 tPorosity = optPorosity;
%                 MeritTemp = TotalMerit;
%             end
%         end
%     end
% 
%     if ViscousCLEst==true,
%         MeritTemp = 100;
%         for optc1 = 0.1:0.01:10
%             TotalMeritCalc(freq(7), freq(8), tFlowRes, tSFactor, tPorosity, optc1, c2);
%             if (TotalMerit<MeritTemp)
%                 c1 = optc1;
%                 MeritTemp = TotalMerit;
%             end
%         end
%     end
% 
%     if ThermalCLEst==true,
%         MeritTemp = 100;
%         for optc2 = 0.1:0.01:c1
%             TotalMeritCalc(1, freq(9), tFlowRes, tSFactor, tPorosity, c1, optc2);
%             if (TotalMerit<MeritTemp)
%                 c2 = optc2;
%                 MeritTemp = TotalMerit;
%             end
%         end
%     end

	%Overall Error Rigid 루틴
	TotalMeritCalc(1, 32, tFlowRes, tSFactor, tPorosity, c1, c2);

    % 에러가 줄었으면 값을 저장
	if (TotalMerit < PrevError)
        FlowRes = tFlowRes;
        SFactor = tSFactor;
        Porosity = tPorosity;

        ViscousCL = sqrt(8*tSFactor*ItaAir/(tPorosity*tFlowRes))/c1;
        ThermalCL = sqrt(8*tSFactor*ItaAir/(tPorosity*tFlowRes))/c2;
    end
