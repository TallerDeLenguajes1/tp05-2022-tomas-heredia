1_ es por referencia
2_ secuencias de escape:
\ '- comilla simple (0x0027)
\ "- comillas dobles (0x0022)
\\ - barra invertida (0x005C)
\ 0 - nulo (0x0000)
\ a - alerta (0x0007)
\ b - retroceso (0x0008)
\ f - alimentación de formulario (0x000C)
\ n - nueva línea (0x000A)
\ r - retorno de carro (0x000D)
\ t - pestaña horizontal (0x0009)
\ v - pestaña vertical (0x000B)
\ u0000 - \ uFFFF - Carácter Unicode
\ x0 - \ xFFFF - Carácter Unicode (código con longitud variable)
\ U00000000 - \ U0010FFFF - Carácter Unicode (para generar sustitutos)
3_
@) Para habilitar el uso de palabras clave de C# como identificadores o para indicar que un literal de cadena se debe interpretar literalmente. 
$ permite interpolar cadenas de texto 