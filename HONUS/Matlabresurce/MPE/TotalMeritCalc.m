
function TotalMeritCalc(Freq1, Freq2, tFlowRes, tSFactor, h, c1, c2)

    global Npr
    global Density1
    global HeatRatio
    global ItaAir
    global P0
    global Densityo
    global Z0
    global B
    
    global freq
    global MAbsorption
    global Frequency

    global BulkDensity
    global Thickness

    global Absorption
    global RealSurfaceImpedance
    global ImagSurfaceImpedance
    global Merit
    global TotalMerit
    
    TotalMerit = 0;
	for ff=Freq1:Freq2,
		Merit=MeritCalc(Frequency(ff), MAbsorption(ff), BulkDensity, tFlowRes, tSFactor, h, c1, c2, Thickness);
		TotalMerit=Merit+TotalMerit;
    end
