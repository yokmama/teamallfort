using UnityEngine;
using System;
using System.Collections;
using live2d;

public class main : MonoBehaviour 
{
	public TextAsset mocFile ;
	public Texture2D[] texture ;
	
	private Live2DModelUnity live2DModel;

	
	void Start () 
	{
		Live2D.init();
		
		live2DModel = Live2DModelUnity.loadModel(mocFile.bytes);
		for(int i = 0; i < texture.Length; i++)
		{
			live2DModel.setTexture( i, texture[i] ) ;
		}
	}
	
	
	void OnRenderObject()
	{
		Matrix4x4 m1=Matrix4x4.Ortho(0,1000.0f,1000.0f,0,-0.5f,0.5f);
		Matrix4x4 m2 = transform.localToWorldMatrix;
		Matrix4x4 m3 = m2*m1;
		live2DModel.setMatrix(m3);
		if( live2DModel == null ) return ;
		
		double t = (UtSystem.getUserTimeMSec()/1000.0) * 2 * Math.PI  ;
		Vector3 vp = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		float mx = (vp.x -0.5f) * 90f;
		float my = (vp.y - 0.5f) * 90f;
		live2DModel.setParamFloat( "PARAM_ANGLE_X" , mx);
		live2DModel.setParamFloat( "PARAM_ANGLE_Y" , my);

		
		live2DModel.update();
		live2DModel.draw();
	}
}