Program comparacao;
Uses CRT;
Var x, y: integer;

Begin
   Writeln('Entre com 2 n�meros: ');
   Readln(x, y);
   If (x > y) Then
   		Writeln ('X � Maior que Y, e seu valor � = ', x)
   Else
      Writeln('Y � Maior que X, e seu valor � = ', y);
  Readkey;
End.