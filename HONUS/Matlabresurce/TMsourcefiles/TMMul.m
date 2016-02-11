function TMMul()
% elseif Travl1==7, T1=TMRigid(L1, Density1,FlowRes1,SFactor1,h1,VCL1,TCL1); thick1=L1; 
global TM;
global Result;
if size(Result,1)<2
    Result = eye(2);
end
if size(TM,1)<2
    TM = eye(2);
end

Result = Result * TM;
