//---- perceptron trenowanie
//---- okreslenie par wektorow trenujacych
//---- dla funktora OR
A=ones(4,4);
A(1,2)=-1; A(1,3)=-1; A(1,4)=-1;
A(2,2)=-1;
A(3,3)=-1;
A(4,4)=-1
//---- wykreslenie obszaru klasyfikacji
//mtlb_hold on;
for i=1:4
 if A(i,4)==1
 plot(A(i,2),A(i,3),'r+:');
 else
 plot(A(i,2),A(i,3),'ko:');
 end
end
mtlb_axis([-2 2 -2 2]);
//---- ustalenie poczatkowych wartosci wag
W=[0 0 0];
Wk=[0 0 0];
lwk=0;
//---- proces trenowania
disp(W);
disp('----------------');
BrakZmiany=0;
Nr_Wektora=round(3*rand())+1;
dawid=0;
disp(Nr_Wektora);
while (dawid<100)
//--- kolejno pobiera wektory trenujace

S=A(Nr_Wektora,1)*W(1)+A(Nr_Wektora,2)*W(2)+A(Nr_Wektora,3)*W(3);
Sig=0;
 if S>0
 Sig=1;
 end
 if S<0
 Sig=-1;
end 
disp(Sig);
if ((Sig>0) & (A(Nr_Wektora,4)==1)) | ((Sig<0) & (A(Nr_Wektora,4)==-1))
 W=W;
 BrakZmiany=BrakZmiany+1;
 if BrakZmiany>lwk
     Wk=W;
     lwk=BrakZmiany;
 else
 BrakZmiany=1;
 if S~=0
 for j=1:3
 W(j)=W(j)+0.5*(A(Nr_Wektora,4)-Sig)*A(Nr_Wektora,j);
 end
 else
 for j=1:3
 W(j)=W(j)+A(Nr_Wektora,4)*A(Nr_Wektora,j);
 end
 end
end
end
disp(Wk);
Nr_Wektora=round(3*rand())+1;
dawid=dawid+1;
end
U1=input("Podaj U1");
U2=input("Podaj U2");
Suma=Wk(1)*1+Wk(2)*U1+Wk(3)*U2;
if Suma >0
    disp(1);
elseif
    Suma <0
    disp(-1);
else
    Suma=0
    disp(0);
end
