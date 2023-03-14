import .Presenter;
import ui.Console;
import ui.interfaces.View;

import java.io.IOException;

public class Main {
    public static void main(String[] args) throws , ClassNotFoundException {
        View view = new Console ();
        new Presenter(view);
        view.start();
    }
}
