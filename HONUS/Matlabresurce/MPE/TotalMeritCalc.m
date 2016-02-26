
function TotalMeritCalc(Freq1, Freq2, tFlowRes, tSFactor, h, c1, c2)

   
    global MAbsorption
    global Frequency
    global BulkDensity
    global Thickness
    global Merit
    global TotalMerit
    
    TotalMerit = 0;
	for ff=Freq1:Freq2,
		Merit=MeritCalc(Frequency(ff), MAbsorption(ff), BulkDensity, tFlowRes, tSFactor, h, c1, c2, Thickness);
		TotalMerit=Merit+TotalMerit;
    end
