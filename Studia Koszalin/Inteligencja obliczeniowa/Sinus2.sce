A=zeros(2,10);
for i=1:10
    A(1,i)=0.25+(10-i)*0.25;
    x=A(1,i);
    A(2,i)=sin(x)*sin(x);
end
plot(A(1,:),A(2,:));
