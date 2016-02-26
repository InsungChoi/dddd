function output = ElasticMeritCalc(c,c1,c2,Density1,DensityA,Densityo,Em,FlowRes,freq,h,HeatRatio,L,LFactor,MeasuredAbsorption,Npr,PRatio,SFactor)
    omega=2*pi*freq;
    k=omega/c;

    s1 = c1*sqrt(8*omega*SFactor*Densityo/(h*FlowRes))*sqrt(-1i);
    s2 = 1/c2*sqrt(Npr)*sqrt(8*omega*SFactor*Densityo/(h*FlowRes))*sqrt(-1i);

    Gc1 = -(s1*besselj(1,s1))/(besselj(0,s1))/(1-2*besselj(1,s1)/(s1*besselj(0,s1)));

    b = FlowRes*h^2*Gc1/4;

    E0=Densityo*(c^2);
    E1=Em*(1+1i*LFactor);
    E2=E0/(1+((2*(HeatRatio-1)/s2)*besselj(1,s2)/besselj(0,s2)));

    A= PRatio*E1/(1+PRatio)/(1-2*PRatio);     % Lame constant
    N = E1/2/(1+PRatio);                      % Shear modulus

    Density11s=Density1+DensityA+b/(1i*omega);
    Density12s=-DensityA-b/(1i*omega);
    Density22s=Densityo*h+DensityA+b/(1i*omega);
    g = -Density12s/Density22s;

    P = A+2*N;
    Q = (1-h)*E2;
    R = h*E2;

    a1 = (Density11s*R-Density12s*Q)/(Density22s*Q-Density12s*R);
    a2 = (P*R-Q^2)/(omega^2*(Density22s*Q-Density12s*R));
    A1 = omega^2*(Density11s*R-2*Density12s*Q+Density22s*P)/(P*R-Q^2);
    A2 = omega^4*(Density11s*Density22s-Density12s^2)/(P*R-Q^2);
    k1 = sqrt((A1+sqrt(A1^2-4*A2))/2.0);
    k2 = sqrt((A1-sqrt(A1^2-4*A2))/2.0);
    kt = sqrt(omega^2/N*(Density11s-Density12s^2/Density22s));

    b1 = a1-a2*k1^2;
    b2 = a1-a2*k2^2;

    AM(1,1) = Q+b1*R;
    AM(1,2) = Q+b1*R;
    AM(1,3) = Q+b2*R;
    AM(1,4) = Q+b2*R;
    AM(1,5) = -1i*h*omega*Densityo;

    AM(2,1) = 2*N+A+b1*Q;
    AM(2,2) = 2*N+A+b1*Q;
    AM(2,3) = 2*N+A+b2*Q;
    AM(2,4) = 2*N+A+b2*Q;
    AM(2,5) = -1i*(1-h)*omega*Densityo;

    AM(3,1) = -omega*(1-h+h*b1)/k1;
    AM(3,2) = omega*(1-h+h*b1)/k1;
    AM(3,3) = -omega*(1-h+h*b2)/k2;
    AM(3,4) = omega*(1-h+h*b2)/k2;
    AM(3,5) = -1i*k;

    AM(4,1) = 1/k1*exp(-1i*k1*L);
    AM(4,2) =-1/k1*exp(1i*k1*L);
    AM(4,3) = 1/k2*exp(-1i*k2*L);
    AM(4,4) =-1/k2*exp(1i*k2*L);

    AM(5,1) = b1/k1*exp(-1i*k1*L);
    AM(5,2) =-b1/k1*exp(1i*k1*L);
    AM(5,3) = b2/k2*exp(-1i*k2*L);
    AM(5,4) =-b2/k2*exp(1i*k2*L);

    DETAM=det(AM);

    BM(1,1) = Q+b1*R;
    BM(1,2) = Q+b1*R;
    BM(1,3) = Q+b2*R;
    BM(1,4) = Q+b2*R;
    BM(1,5) = 1i*h*omega*Densityo;

    BM(2,1) = 2*N+A+b1*Q;
    BM(2,2) = 2*N+A+b1*Q;
    BM(2,3) = 2*N+A+b2*Q;
    BM(2,4) = 2*N+A+b2*Q;
    BM(2,5) = 1i*(1-h)*omega*Densityo;

    BM(3,1) = -omega*(1-h+h*b1)/k1;
    BM(3,2) = omega*(1-h+h*b1)/k1;
    BM(3,3) = -omega*(1-h+h*b2)/k2;
    BM(3,4) = omega*(1-h+h*b2)/k2;
    BM(3,5) = -1i*k;

    BM(4,1) = 1/k1*exp(-1i*k1*L);
    BM(4,2) =-1/k1*exp(1i*k1*L);
    BM(4,3) = 1/k2*exp(-1i*k2*L);
    BM(4,4) =-1/k2*exp(1i*k2*L);

    BM(5,1) = b1/k1*exp(-1i*k1*L);
    BM(5,2) =-b1/k1*exp(1i*k1*L);
    BM(5,3) = b2/k2*exp(-1i*k2*L);
    BM(5,4) =-b2/k2*exp(1i*k2*L);


    DETBM=det(BM);

    Ref=DETBM/DETAM;
    Z=(1+Ref)/(1-Ref);

    %SurfaceImpedance=abs(Z);
    RealSurfaceImpedance=real(Z);
    ImagSurfaceImpedance=imag(Z);
    Absorption=1-(abs(Ref))^2;

    Merit=(MeasuredAbsorption-Absorption)^2;
    output = [Merit Absorption RealSurfaceImpedance ImagSurfaceImpedance];