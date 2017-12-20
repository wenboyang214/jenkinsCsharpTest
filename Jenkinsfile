#!/usr/bin/env groovy Jenkinsfile
node{
	stage('test')
	{
		echo "hello world"
	}
	stage('test nuget.exe')
	{
		bat "${env.WORKSPACE}\\cicd\\nuget.exe help"
	}
}