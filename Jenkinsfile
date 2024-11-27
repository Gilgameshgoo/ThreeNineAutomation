pipeline {
  agent any
  stages {
    stage('Restore SDK') {
      steps {
        dotnetRestore()
      }
    }

    stage('Build') {
      steps {
        dotnetBuild(configuration: 'UAT')
      }
    }

    stage('') {
      steps {
        dotnetTest(configuration: 'QA', listTests: true)
      }
    }

  }
}