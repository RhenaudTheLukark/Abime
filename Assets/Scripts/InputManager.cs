using UnityEngine;
using System.Collections;

public class InputManager {
    // 4 button states
    public enum ButtonState {
        RELEASED = -1,
        NONE = 0,
        PRESSED = 1,
        HELD = 2
    }

    KeyCode KC_UP = KeyCode.Z, KC_UP_ALT = KeyCode.UpArrow,
            KC_DOWN = KeyCode.S, KC_DOWN_ALT = KeyCode.DownArrow,
            KC_LEFT = KeyCode.Q, KC_LEFT_ALT = KeyCode.LeftArrow,
            KC_RIGHT = KeyCode.D, KC_RIGHT_ALT = KeyCode.RightArrow;
    
    public ButtonState Up    { get { return stateFor(KC_UP,    KC_UP_ALT);    } }
    public ButtonState Down  { get { return stateFor(KC_DOWN,  KC_DOWN_ALT);  } }
    public ButtonState Left  { get { return stateFor(KC_LEFT,  KC_LEFT_ALT);  } }
    public ButtonState Right { get { return stateFor(KC_RIGHT, KC_RIGHT_ALT); } }

    public ButtonState Key(string Key) { return stateFor((KeyCode) System.Enum.Parse(typeof(KeyCode), Key)); }

    private ButtonState stateFor(KeyCode c) {
        if (Input.GetKeyDown(c))    return ButtonState.PRESSED;
        else if (Input.GetKeyUp(c)) return ButtonState.RELEASED;
        else if (Input.GetKey(c))   return ButtonState.HELD;
        else                        return ButtonState.NONE;
    }

    private ButtonState stateFor(params KeyCode[] keys) {
        foreach (KeyCode key in keys) {
            ButtonState state = stateFor(key);
            if (state != ButtonState.NONE)
                return state;
        }
        return ButtonState.NONE;
    }
}