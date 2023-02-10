import "csharp";
import "puerts";
import UIRoot from "../ui_scripts/uiroot.mjs";
import ptypeof = puer.$typeof;
import ppromise = puer.$promise;
import fgui = CS.FairyGUI;
import ET = CS.ET;
import AO = CS.AO;
import AOGame = CS.AO.AOGame;

// 属性变更通知：等级
function Level_Changed (avatar: AO.Avatar) {

}

export function register() {
    UIRoot.FuncMap.set("Avatar_Level_Changed", Level_Changed);
}