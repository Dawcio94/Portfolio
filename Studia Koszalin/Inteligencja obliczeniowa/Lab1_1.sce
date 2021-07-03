wykres=zeros(5,361);
for i=1:361
    wykres(1,i)=(i/2)-1;
    x=wykres(1,i);
if x>=0 & x<=40
    uA=(40-x)/40;
else
    uA=0;
end
wykres(2,i)=uA;
if x>=20 & x<=40
    sredni=(x-20)/20;
elseif x>40 & x<60
    sredni=1;
elseif x>=60 & x<=90
    sredni=(90-x)/30;
    else sredni=0
end
//trapez
wykres(3,i)=sredni;
if x>=70 & x<=100
    wysoki=(x-70)/30;
elseif x>100 & x<130
    wysoki=(130-x)/30;
else wysoki=0;
end
//trojkat
wykres(4,i)=wysoki;
if x>=110 & x<=140
    bwysoki=(x-110)/30;
elseif x>140 & x<180
    bwysoki=1;
else bwysoki=0
end
wykres(5,i)=bwysoki;
end
plot(wykres(1,:),wykres(2,:),'r');
plot(wykres(1,:),wykres(3,:),'g');
plot(wykres(1,:),wykres(4,:),'b');
plot(wykres(1,:),wykres(5,:),'y');
mtlb_axis([0 180 0 1.2]);
