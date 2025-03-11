using UnityEngine;
using UnityEngine.XR;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class XRController : MonoBehaviour
{
    public XRNode inputSource;
    
    [SerializeField] private InputActionReference selectAction; // 선택 버튼 (PrimaryButton)
    [SerializeField] private InputActionReference activateAction; // 활성화 버튼 (SecondaryButton)
    [SerializeField] private InputActionReference gripAction; // 그립 버튼 (Grip)

    private void Awake()
    {
    
        if (selectAction != null)
            selectAction.action.Enable();
        
        if (activateAction != null)
            activateAction.action.Enable();
        
        if (gripAction != null)
            gripAction.action.Enable();
    }

    private void Update()
    {
        // 실제 Action에서 입력이 있으면 동작
        if (selectAction != null && selectAction.action.ReadValue<float>() > 0)
        {
            Debug.Log("Select 버튼이 눌렸습니다.");
        }

        if (activateAction != null && activateAction.action.ReadValue<float>() > 0)
        {
            Debug.Log("Activate 버튼이 눌렸습니다.");
        }

        if (gripAction != null && gripAction.action.ReadValue<float>() > 0)
        {
            Debug.Log("Grip 버튼이 눌렸습니다.");
        }

        // 테스트용 입력
        if (Keyboard.current.spaceKey.isPressed)  // 'Space' 키로 테스트
        {
            Debug.Log("Select 버튼(스페이스바)이 눌렸습니다.");
        }

        if (Keyboard.current.enterKey.isPressed)  // 'Enter' 키로 테스트
        {
            Debug.Log("Activate 버튼(엔터키)이 눌렸습니다.");
        }

        if (Keyboard.current.leftShiftKey.isPressed)  // 'Shift' 키로 테스트
        {
            Debug.Log("Grip 버튼(Shift키)이 눌렸습니다.");
        }
    }
}
