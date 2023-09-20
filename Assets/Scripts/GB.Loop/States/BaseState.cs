namespace GB.Loop
{
    public abstract class BaseState 
    {
        protected GameController gameController;
        //awake

        public virtual void BeforeInitialize(GameController gameController)
        {
            this.gameController = gameController;
        }

        //start
        public virtual void Initialize()
        {

        }

        //update
        public virtual void Tick()
        {

        }

        //fixedUpdate
        public virtual void FixedTick()
        {

        }

        //lateUpdate
        public virtual void LateTick()
        {

        }

        //OnDestroy
        public virtual void Dispose()
        {

        }


    }
}


