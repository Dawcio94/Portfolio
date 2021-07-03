A=ones(8,5);
A(1,2)=-1;A(1,3)=-1;A(1,4)=-1;A(1,5)=-1;
A(2,2)=-1;A(2,3)=-1;A(2,5)=-1;
A(3,2)=-1;A(3,4)=-1;A(3,5)=-1;
A(4,2)=-1;A(4,5)=-1;
A(5,3)=-1;A(5,4)=-1;A(5,5)=-1;
A(6,3)=-1;
A(7,4)=-1;A(7,5)=-1;
A(8,5)=-1;
W=[0 0 0 0];
BrakZmiany=0;
Nr_Wektora=1;
while (BrakZmiany<8)
//--- kolejno pobiera wektory trenujace
S=A(Nr_Wektora,1)*W(1)+A(Nr_Wektora,2)*W(2)+A(Nr_Wektora,3)*W(3)+A(Nr_Wektora,4)*W(4);
Sig=0;
 if S>0
 Sig=1;
 end
 if S<0
 Sig=-1;
end 
if ((Sig>0) & (A(Nr_Wektora,5)==1)) | ((Sig<0) & (A(Nr_Wektora,5)==-1))
 W=W;
 BrakZmiany=BrakZmiany+1;
 else
 BrakZmiany=0;
 if S~=0
 for j=1:4
 W(j)=W(j)+0.5*(A(Nr_Wektora,5)-Sig)*A(Nr_Wektora,j);
 end
 else
 for j=1:4
 W(j)=W(j)+A(Nr_Wektora,5)*A(Nr_Wektora,j);
 end
 end
 end
 disp(W);
 Nr_Wektora=Nr_Wektora+1;
 if Nr_Wektora>8
 Nr_Wektora=1;
 end
 end
//---- wykreslenie otrzymanej linii podzialu
U1=input("Podaj U1 ");
U2=input("Podaj U2 ");
U3=input("Podaj U3 ");
Suma=W(1)*1+W(2)*U1+W(3)*U2+W(4)*U3;

if Suma >0
    disp(1);
elseif Suma <0
    disp(-1);
else
    Suma=0
    disp(0);
end
