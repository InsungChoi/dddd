function PolyFitting(FrequencyFitted, FrequencySampled, DataSampled, n)

    global DataFitted

    P1=polyfit(FrequencySampled,DataSampled,n);

    DataFitted=Polyval(P1,FrequencyFitted);
