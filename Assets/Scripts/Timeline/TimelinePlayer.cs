/****************************************************
文件：TimelinePlayer.cs
作者：ZED
日期：2019/12/15 14:51:28
功能：Timeline播放器
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimelinePlayer : MonoBehaviour
{
    public PlayableDirector playableDirector = null;

    private bool isPlayStart = false;

    private void Start()
    {
        if (null != playableDirector)
        {
            playableDirector.playableAsset = ResModule.Load<PlayableAsset>("Timeline/Timeline001.playable");
            var outputAssets = playableDirector.playableAsset.outputs;
            foreach (var item in outputAssets)
            {
                if (item.streamName.Equals("显示隐藏目标"))
                {
                    ActivationGameObjectTrack activationAsset = item.sourceObject as ActivationGameObjectTrack;
                    foreach (var clip in activationAsset.GetClips())
                    {
                        if (clip.displayName.Equals("Disaplay"))
                        {
                            ActivationAsset asset = clip.asset as ActivationAsset;
                            asset.target = GameObject.Find("Unlit");
                        }
                    }
                }
                Debug.Log("当前PlayBinding的名称为：" + item.streamName);
            }
            playableDirector.Play();


            //playableDirector.RebuildGraph();
            //PlayableGraph playableGraph = playableDirector.playableGraph;

            

            //isPlayStart = true;
            //playableDirector.Play();

            //var outputCount = playableGraph.GetOutputCount();
            //Debug.Log("当前的通道输出数量：" + outputCount);
            //for (int i = 0; i < outputCount; i++)
            //{
            //    var outputGraph = playableGraph.GetOutput(i);
                
            //}
            //Object @object = outputGraph.GetUserData();
            //Debug.Log("当前UserData的名称是：" + @object.name);
            //if (null != playableDirector.playableAsset)
            //{
            //    playableDirector.Play();
            //}
        }
    }

    private void Update()
    {
        if (isPlayStart)
        {
            if (!(playableDirector.state == PlayState.Playing))
            {
                Debug.Log("xxxxxxxxxxxxxxxxxxxxxxxx");
                isPlayStart = false;
            }
        }
    }
}

