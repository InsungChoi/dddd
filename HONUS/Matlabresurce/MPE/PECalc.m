function PECalc(PrevError)

    
    
    
    global ItaAir
    global FlowRes
    global SFactor
    global Porosity
    global ViscousCL
    global ThermalCL
    global TotalMerit

    tFlowRes = FlowRes
    tSFactor = SFactor
    tPorosity = Porosity


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
