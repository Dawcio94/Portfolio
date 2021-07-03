zx=zeros(4,101);
zy=zeros(4,101);
wn=zeros(4,101);
X=input('Podaj x');
for i=1:101
    zx(1,i)=(i/2)-0.5;
    x=zx(1,i);
 if x>20 & x<=30
    A=(30-x)/10;
elseif x>=0 & x<=20
    A=1;
else A=0;
end
zx(2,i)=A;
if x>=20 & x<=30
    B=(x-20)/10;
elseif x>30 & x<40
    B=(40-x)/10;
else B=0;
end
zx(3,i)=B;
if x>=30 & x<=40
    C=(x-30)/10;
elseif x>40
    C=1;
else C=0;
end
zx(4,i)=C
    zy(1,i)=i-1;
    y=zy(1,i);
    if y>=0 & y<=50
        D=(50-y)/50;
     else D=0;
     end
zy(2,i)=D;
if y>=20 & y<=60
    E=(y-20)/40;
elseif y>60 & y<80
    E=(80-y)/20;
else E=0;
end
zy(3,i)=E;
if y>=60 & y<=100
    F=(y-60)/40;
else F=0;
end
zy(4,i)=F;
end
ind=2*X+1;
ua=zx(2,ind);
ub=zx(3,ind);
uc=zx(4,ind);
//rozmycie
disp(ua);
disp(ub);
disp(uc);
for i=1:101
    ud=zy(2,i);
    ue=zy(3,i);
    uf=zy(4,i);
//rozmycie
if ua>0
    wn(1,i)=min(ua,ud);
end
if ub>0
    wn(2,i)=min(ub,ue);
end
if uc>0
    wn(3,i)=min(uc,uf);
end
//wnioskowanie
wn(4,i)=max(wn(1,i),wn(2,i),wn(3,i));
//agregacja
end
licznik=0;
mianownik=0;
for i=1:101
    licznik=licznik+(wn(4,i)*zy(1,i));
    mianownik=mianownik+wn(4,i);
end
ostre=licznik/mianownik;
disp(ostre);
subplot(4,1,1);
plot(zx(1,:),zx(2,:),'r');
plot(zx(1,:),zx(3,:),'b');
plot(zx(1,:),zx(4,:),'g');
mtlb_axis([0 50 0 1.2]);
subplot(4,1,2);
plot(zy(1,:),zy(2,:),'r');
plot(zy(1,:),zy(3,:),'b');
plot(zy(1,:),zy(4,:),'g');
mtlb_axis([0 100 0 1.2]);
subplot(4,1,3);
plot(zy(1,:),wn(1,:),'r');
plot(zy(1,:),wn(2,:),'b');
plot(zy(1,:),wn(3,:),'g');
mtlb_axis([0 100 0 1.2]);
subplot(4,1,4);
plot(zy(1,:),wn(4,:),'r');
mtlb_axis([0 100 0 1.2]);
