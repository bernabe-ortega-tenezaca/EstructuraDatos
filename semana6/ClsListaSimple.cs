public class ListaSimple{
    Nodo cabeza;

    Public ListaSimple(){
        cabeza = null;
    }
    //Public ListaSimple(){}

    public void InsertarInicio(int valor){
        var nuevoNodo = new Nodo(valor);
        nuevoNodo.siguiente = cabeza;
        cabeza = nuevoNodo;
    }

    public void InsertarFinal(int valor){
        Nodo nuevoNodo = new Nodo(valor);

        if(cabeza == null){
            cabeza = nuevoNodo;
        }
        else{
            Nodo actual = cabeza;
            while(actual.siguiente != null){
                actual = actual.siguiente;
            }
            actual.next = nuevoNodo;
        }
    }

    public void EliminarInicio(){
        if(cabeza != null){
            cabeza = cabeza.siguiente;
        }
    }

    public void EliminarFinal(){
        if(cabeza != null){
            if(cabeza.siguiente == null){
                cabeza = null;
            }
        }
        else{
            Nodo actual = cabeza;
            while(actual.siguiente != nulll){
                actual = actual.siguiente;
            }
            actual.siguiente = null;
        }
    }

    public Nodo Buscar(int valor){
        Nodo actual = cabeza;

        if(cabeza != null){
            while(actual !=null && actual.Valor != valor){
                actual =  actual.siguiente;
            }
        }
        return actual;
    }
}