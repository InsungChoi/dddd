function TMCheck()
global TM Result;
global TM11 TM12 TM21 TM22 Result11 Result12 Result21 Result22;

TM11 = abs(TM(1,1));
TM12 = abs(TM(1,2));
TM21 = abs(TM(2,1));
TM22 = abs(TM(2,2));
Result11 = abs(Result(1,1));
Result12 = abs(Result(1,2));
Result21 = abs(Result(2,1));
Result22 = abs(Result(2,2));

