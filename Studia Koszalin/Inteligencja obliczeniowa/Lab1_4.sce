wykres=zeros(6,401)
for i=1:401
    wykres(1,i)=(i/4)-0.25;
    x=wykres(1,i);
if x>=30 & x<=40
    wysoki=(x-30)/10;
elseif x>40 & x<50
    wysoki=(50-x)/10;
else wysoki=0;
end
wykres(2,i)=wysoki;
if x>=40 & x<=60
    bwysoki=(x-40)/20;
elseif x>60 & x<=70
    bwysoki=(70-x)/10;
else bwysoki=0;
end
wykres(3,i)=bwysoki;
wykres(4,i)=wysoki*bwysoki;
wykres(5,i)=(wysoki+bwysoki)-(wysoki*bwysoki);
wykres(6,i)=1-wysoki;
end
subplot(4,1,1);
plot(wykres(1,:),wykres(2,:),'r');
plot(wykres(1,:),wykres(3,:),'g');
subplot(4,1,2);
plot(wykres(1,:),wykres(4,:),'b');
subplot(4,1,3)
plot(wykres(1,:),wykres(5,:),'b');
subplot(4,1,4)
plot(wykres(1,:),wykres(6,:),'b');
mtlb_axis([0 100 0 1.2]);
