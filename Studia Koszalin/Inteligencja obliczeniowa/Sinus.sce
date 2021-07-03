A=zeros(2,101);
for i=1:101
    A(1,i)=0+(101-i)*0.01;
    x=A(1,i);
    A(2,i)=sin(x);
end
plot(A(1,:),A(2,:));
