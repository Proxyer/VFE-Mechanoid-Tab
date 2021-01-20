using RimWorld;
using RimWorld.Planet;
using System.Collections.Generic;
using System.Linq;
using Verse;

namespace VFEMT
{
    public class MainTabWindow_Mechanoids : MainTabWindow_PawnTable
    {
        [DefOf]
        public static class PawnTableDefOf
        {
            public static PawnTableDef VFEMT_Mechanoids;
        }

        protected override PawnTableDef PawnTableDef => PawnTableDefOf.VFEMT_Mechanoids;

        protected override IEnumerable<Pawn> Pawns => from p in Find.CurrentMap.mapPawns.PawnsInFaction(Faction.OfPlayer)
                                                      where p.RaceProps.IsMechanoid
                                                      select p;
        public override void PostOpen()
        {
            base.PostOpen();
            Find.World.renderer.wantedMode = WorldRenderMode.None;
        }
    }
}
