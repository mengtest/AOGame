/** This is an automatically generated class by FairyGUI. Please do not modify it. **/
import UI_CommonWindowFrame from "../Common/UI_CommonWindowFrame.mjs";
import UI_InputComponent from "./UI_InputComponent.mjs";
import "csharp";
var fgui = CS.FairyGUI;
import UIWindow from "../../../ui_base/uiwindow.mjs";
import UIRoot from "../../uiroot.mjs";
export default class UI_LoginWindow extends UIWindow {
    constructor(GObject) {
        super(GObject);
        this.GComponent = GObject.asCom;
        this.g_frame = new UI_CommonWindowFrame(this.GComponent.GetChildAt(0));
        this.g_loginBtn = this.GComponent.GetChildAt(1);
        this.g_accountInput = new UI_InputComponent(this.GComponent.GetChildAt(2));
        this.g_passwordInput = new UI_InputComponent(this.GComponent.GetChildAt(3));
    }
    static getInstance() {
        return UIRoot.Windows.get("UI_LoginWindow");
    }
    static createInstance() {
        let GObject = (fgui.UIPackage.CreateObject("Login", "LoginWindow"));
        var ui = new UI_LoginWindow(GObject);
        return ui;
    }
}
UI_LoginWindow.URL = "ui://hlimh2ngwewl5";
