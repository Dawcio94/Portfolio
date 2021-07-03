x = -10:0.1:10;
y = -10:0.1:10;

[X,Y] = meshgrid(x,y);

for i=1:size(X,1)
  for j=1:size(X,2)
    Z(i,j) = X(i,j)*X(i,j)+Y(i,j)*Y(i,j);
  end
end

surf(X,Y,Z)
