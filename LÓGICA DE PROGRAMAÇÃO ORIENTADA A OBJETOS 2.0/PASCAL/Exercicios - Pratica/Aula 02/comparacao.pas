Program comparacao;
Uses CRT;
Var x, y: integer;

Begin
   Writeln('Entre com 2 números: ');
   Readln(x, y);
   If (x > y) Then
   		Writeln ('X é Maior que Y, e seu valor é = ', x)
   Else
      Writeln('Y é Maior que X, e seu valor é = ', y);
  Readkey;
End.