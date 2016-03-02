function DataFitted = PolyFitting(DataSampled,FrequencyFitted,FrequencySampled,n)
    P1=polyfit(FrequencySampled,DataSampled,n);
    DataFitted=polyval(P1,FrequencyFitted);
