temp=zeros(5,71);
wilg=zeros(4,101);
podl=zeros(4,101);
zimno=0;
letnio=0;
cieplo=0;
goraco=0;
mala=0;
srednia=0;
duza=0;
X1=input('Podaj temperature');
X2=input('Podaj wilgotnosc w %');
for i=1:71
    temp(1,i)=(i/2)-0.5;
    x=temp(1,i);
    if x>= 5 & x<=15
        zimno=(15-x)/10;
    elseif x>=0 & x<5
        zimno=1   
    else
        zimno=0;
end
temp(2,i)=zimno;
//trojkat w dol
if x>=5 & x<=15
    letnio=(x-5)/10;
elseif x>15 &x<=25
    letnio=(25-x)/10;
else
    letnio=0;
end
temp(3,i)=letnio;
if x>=15 & x<=25
    cieplo=(x-15)/10;
elseif x>25 &x<=35
    cieplo=(35-x)/10;
else
    cieplo=0;
end
//caly trojkat
temp(4,i)=cieplo;
if x>=25 & x<=35
    goraco=(x-25)/10;
elseif x<25
    goraco=0;
else 
    goraco=1;
end
temp(5,i)=goraco;
end
for i=1:101
    wilg(1,i)=i-1;
    z=wilg(1,i);
    if z>= 25 & z<=50
        mala=(50-z)/25;
    elseif z>=0 & z<25
        mala=1   
    else
        mala=0;
    end
wilg(2,i)=mala;
if z>=25 & z<=50
    srednia=(z-25)/25;
elseif z>50 &z<=100
    srednia=(100-z)/50;
else
    srednia=0;
end
wilg(3,i)=srednia;
if z>=50 & z<=100
    duza=(z-50)/50;
elseif z<50
    duza=0;
else 
    duza=1;
end
wilg(4,i)=duza;
end
ind=2*X1+1;
uz=temp(2,ind);
ul=temp(3,ind);
uc=temp(4,ind);
ug=temp(5,ind);
disp(uz);
disp(ul);
disp(uc);
disp(ug);
ind1=X2+1;
um=wilg(2,ind1);
us=wilg(3,ind1);
ud=wilg(4,ind1);
disp(um);
disp(us);
disp(ud);
if uz >0 & um>0
    us1=min (uz,um);
else
    us1=0;
end

if ul >0 & um>0
    ud1=min (ul,um);
else
    ud1=0;
end
if uc >0 & um>0
    ud2=min (uc,um);
else
    ud2=0;
end
if ug >0 & um>0
    umax=min (ug,um);
else
    umax=0;
end
if uz >0 & us>0
    um1=min (uz,us);
else
    um1=0;
end
if ul >0 & us>0
    um2=min (ul,us);
else
    um2=0;
end
if uc >0 & us>0
    us2=min (uc,us);
else
    us2=0;
end
if ug >0 & us>0
    ud3=min (ug,us);
else
    ud3=0;
end
if uz >0 & ud>0
    uz1=min (uz,ud);
else
    uz1=0;
end
if ul >0 & ud>0
    uz2=min (ul,ud);
else
    uz2=0;
end
if uc >0 & ud>0
    um3=min (uc,ud);
else
    um3=0;
end
if ug >0 & ud>0
    us3=min (ug,ud);
else
    us3=0;
end
usc=max(us1,us2,us3);
umc=max(um1,um2,um3);
udc=max(ud1,ud2,ud3);
uzc=max(uz1,uz2);
licznik=0;
mianownik=0;
licznik=uzc*0+umc*25+usc*50+udc*75+umax*100;
mianownik=uzc+umc+usc+udc+umax;
y=licznik/mianownik;
disp(y);
subplot(2,1,1);
plot(temp(1,:),temp(2,:),'r');
plot(temp(1,:),temp(3,:),'g');
plot(temp(1,:),temp(4,:),'b');
plot(temp(1,:),temp(5,:),'r');
mtlb_axis([0 35 0 1.2]);
subplot(2,1,2);
plot(wilg(1,:),wilg(2,:),'r');
plot(wilg(1,:),wilg(3,:),'g');
plot(wilg(1,:),wilg(4,:),'b');
mtlb_axis([0 100 0 1.2]);


