Feature: Search
![Search](https://abr.business.gov.au/)
Simple calculator for adding **two** numbers

Link to a feature: [Search](SpecFlowBDDAutomationFramework/Features/Search.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Search Active ABNs
	Given User is on the landing page
	When User types 'TEST & TEACH' on the search field
	And User clicks the search button 
	Then There should be results under Active ABNs