using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GB.Data;
using GB.Player;
using GB.UI;
using GB.Score;
using GB.Level;
namespace GB.Loop
{
    public class GameController : MonoBehaviour
    {
        [SerializeField]
        private GameDataStorage gameDataStorage;

        [SerializeField]
        private PlayerMovement playerMovement;

        [SerializeField]
        private CameraController cameraController;

        [SerializeField]
        private UIController uiController;

        [SerializeField]
        private LevelSpawner levelSpawner;


        private HeightSystem heightSystem;
        private TimeSystem timeSystem;
        private InputSystem inputSystem;
        private GemSystem gemSystem;



        public GameDataStorage GameDataStorage => gameDataStorage;
        public PlayerMovement PlayerMovement => playerMovement;
        public CameraController CameraController => cameraController;
        public UIController UIController => uiController;
        public HeightSystem HeightSystem => heightSystem;
        public TimeSystem TimeSystem => timeSystem;
        public InputSystem InputSystem => inputSystem;
        public LevelSpawner LevelSpawner => levelSpawner;
        public GemSystem GemSystem => gemSystem;

        private BaseState currentState;
        private void Awake()
        {
            heightSystem = new HeightSystem();
            timeSystem = new TimeSystem();
            inputSystem = new InputSystem();
            gemSystem = new GemSystem();
        }

        void Start()
        {
            playerMovement.InitializeSystem(gameDataStorage,gemSystem,levelSpawner);
            cameraController.InitializeSystem(gameDataStorage);
            gemSystem.InitializeGems(uiController.GameView);
            ChangeState(new MenuState());
        }
       
        void Update()
        {
            currentState?.Tick();
        }

        private void FixedUpdate()
        {
            currentState?.FixedTick();
        }

        private void LateUpdate()
        {
            currentState?.LateTick();
        }

        public void ChangeState(BaseState newState)
        {
            currentState?.Dispose(); //OnDestroy
            currentState = newState;
            currentState?.BeforeInitialize(this); //Awake
            currentState?.Initialize(); //Start
        }

    }
}

