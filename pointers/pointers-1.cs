// Los punteros son tipos de datos especiales que nos permiten acceder a valores que estan en
// posiciones de memoria especificas. Por defecto c# provee herramientas seguras que no permiten
// que accedamos directamente a memoria ni podamos asignar o liberar memoria.

// c# ademas nos provee de contextos inseguros donde si podemos asignar, liberar y acceder a memoria.

int[] list = new int[3] {1, 2, 3};

int n = 30;

string nombre = "Diego";

unsafe {
    fixed(int* miPuntero = &list[0]) {
        Console.WriteLine(*miPuntero);
    };

    int* nPuntero = &n;
    Console.WriteLine(*nPuntero);

    //tambien podriamos mostrar letra por letra
    fixed(char* nombrePuntero = nombre) {
        Console.WriteLine(*nombrePuntero);
    }

}