﻿using System.Collections;
using NitroxClient.MonoBehaviours;
using NitroxModel.DataStructures.GameLogic;
using NitroxModel.DataStructures.Util;
using NitroxModel.Helper;
using UnityEngine;

namespace NitroxClient.GameLogic.Spawning
{
    public class CrashEntitySpawner : IEntitySpawner
    {
        /**
         * Crash fish are spawned by the CrashHome in the Monobehaviours Start method
         */
        public IEnumerator Spawn(TaskResult<Optional<GameObject>> result, Entity entity, Optional<GameObject> parent, EntityCell cellRoot)
        {
            if (parent.HasValue)
            {
                CrashHome crashHome = parent.Value.GetComponent<CrashHome>();

                GameObject gameObject = Object.Instantiate(crashHome.crashPrefab, Vector3.zero, Quaternion.Euler(-90f, 0f, 0f));
                gameObject.transform.SetParent(crashHome.transform, false);
                NitroxEntity.SetNewId(gameObject, entity.Id);
                crashHome.ReflectionSet("crash", gameObject.GetComponent<Crash>());
            }
            result.Set(Optional.Empty);
            yield break;
        }

        public bool SpawnsOwnChildren()
        {
            return false;
        }
    }
}
