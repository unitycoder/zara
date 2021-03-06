using System.Collections.Generic;
using System.Linq;
using ZaraEngine.Diseases.Stages;
using ZaraEngine.Injuries;

namespace ZaraEngine.Diseases
{

    public enum DiseaseLevels
    {
        InitialStage = 2,
        Progressing = 3,
        Worrying = 4,
        Critical = 5,
        HealthyStage = 1
    }

    public abstract class DiseaseDefinitionBase
    {

        public string Name { get; protected set; }

        public List<DiseaseStage> Stages { get; protected set; }

        public bool IsDynamic { get; protected set; }

        public bool RequiresBodyPart{ get; protected set; }

        public virtual void Check(ActiveDisease disease, IGameController gc)
        {
            
        }

        public virtual void OnResumeDisease()
        {
            
        }

        public void SwapChain(List<DiseaseStage> stages)
        {
            Stages = stages;
        }

        public virtual void InitializeWithInjury(BodyParts initialInjury)
        {

        }

    }

}
