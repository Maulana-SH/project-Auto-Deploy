Imports System.ComponentModel

Public Class dataHelper
    'Public Shared Function LoadData() As IList(Of Task)
    '    Dim tasks = New List(Of Task)()
    '    Dim softwareDevelopment As New Task("Software Development", 0, -1, DateTime.Now, 1, 24)
    '    Dim analyseRequirements As New Task("Analyse Requirements", 1, softwareDevelopment.Id, softwareDevelopment.StartDate, 1, 100)
    '    Dim developFunctionalSpecifications As New Task("Develop functional specifications", 2, softwareDevelopment.Id, analyseRequirements.FinishDate, 1, 100, 1)
    '    Dim developSoftware As New Task("Develop software", 3, softwareDevelopment.Id, developFunctionalSpecifications.FinishDate, 5, 40, developFunctionalSpecifications.Id)
    '    Dim developHelpSystem As New Task("Develop help system", 4, softwareDevelopment.Id, developFunctionalSpecifications.FinishDate, 1, 90, developFunctionalSpecifications.Id)
    '    Dim developUserManuals As New Task("Develop user manuals", 5, softwareDevelopment.Id, developHelpSystem.FinishDate, 1, 0, developHelpSystem.Id)
    '    Dim testSoftware As New Task("Test software", 6, softwareDevelopment.Id, developSoftware.FinishDate, 2, 0, developSoftware.Id)
    '    Dim deployBeta As New Task("Deploy Beta", 7, softwareDevelopment.Id, testSoftware.FinishDate, 0, 0, testSoftware.Id)
    '    Dim collectFeedback As New Task("Collect feedback", 8, softwareDevelopment.Id, deployBeta.FinishDate, 2, 0, deployBeta.Id)
    '    Dim fixBugs As New Task("Fix bugs", 9, softwareDevelopment.Id, collectFeedback.FinishDate, 2, 0, collectFeedback.Id)
    '    Dim incorporateFeedBack As New Task("Incorporate feedback", 10, softwareDevelopment.Id, collectFeedback.FinishDate, 3, 0, collectFeedback.Id)
    '    Dim releaseSoftware As New Task("Release software", 11, softwareDevelopment.Id, incorporateFeedBack.FinishDate, 2, 0, fixBugs.Id, incorporateFeedBack.Id)
    '    Dim createSoftwareMaintenanceTeam As New Task("Create software maintenance team", 12, softwareDevelopment.Id, deployBeta.FinishDate, 1, 0, developSoftware.Id)
    '    Dim softwareDevelopmentComplete As New Task("Software development complete", 13, softwareDevelopment.Id, releaseSoftware.FinishDate, 0, 0, releaseSoftware.Id)
    '    softwareDevelopment.FinishDate = softwareDevelopmentComplete.FinishDate
    '    tasks.AddRange(New Task() {softwareDevelopment, analyseRequirements, developFunctionalSpecifications, developSoftware, developHelpSystem, developUserManuals,
    '                   testSoftware, deployBeta, collectFeedback, fixBugs, incorporateFeedBack, releaseSoftware, createSoftwareMaintenanceTeam, softwareDevelopmentComplete})
    '    Return tasks
    'End Function

End Class
