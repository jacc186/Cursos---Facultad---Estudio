/*a.	-Declarar 2 variables de tipo int, asignar 5 y 7 respectivamente
b.	-Declarar 2 variables de tipo apuntador a int que apunten a las variables previamente creadas
c.	-Mostrar en pantalla la suma de ambos valores usando los punteros
d.        -Mostrar en pantalla la dirección de memoria de ambas (las 2 iniciales).
d.	-Mostrar en pantalla el tamaño de las variables (las 2 iniciales)
*/
package main

import (
	"fmt"
	"unsafe"
)

func main() {
	var a int = 5
	var b int = 7
	var c *int = &a
	var d *int = &b

	fmt.Println("La suma de la variable a y b es: {0}", +*c+*d)
	fmt.Println("La direccion de memoria de a es: {0}", &a)
	fmt.Println("La direccion de memoria de b es: {0}", &b)
	fmt.Println("El tamaño de la variable a es de:{0}", unsafe.Sizeof(a))
	fmt.Println("El tamaño de la variable b es de:{0}", unsafe.Sizeof(b))
}
