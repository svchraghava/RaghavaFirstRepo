node {
   stage("get code from SCM"){
       
       checkout([$class: 'GitSCM', branches: [[name: '*/Develop']], doGenerateSubmoduleConfigurations: false, extensions: [], submoduleCfg: [], userRemoteConfigs: [[credentialsId: 'Githubcredentials', url: 'https://github.com/svchraghava/RaghavaFirstRepository.git']]])
       
   }
   
   stage("echo statement"){
       sh 'ls -ltr'
   }
   
   
}
