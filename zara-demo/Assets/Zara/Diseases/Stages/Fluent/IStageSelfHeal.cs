using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZaraEngine.Diseases.Stages.Fluent
{
    public interface IStageSelfHeal
    {

        IStageVitalsNode SelfHealChance(int percent);

        IStageVitalsNode NoSelfHeal();

    }
}
