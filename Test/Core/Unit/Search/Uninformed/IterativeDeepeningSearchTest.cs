namespace AIMA.Test.Core.Unit.Search.Uninformed;

using java.util.List;

using org.junit.Assert;
using org.junit.Test;

using AIMA.Core.Agent.Action;
using AIMA.Core.Environment.NQueens.NQueensBoard;
using AIMA.Core.Environment.NQueens.NQueensFunctionFactory;
using AIMA.Core.Environment.NQueens.NQueensGoalTest;
using AIMA.Core.Search.Framework.Problem;
using AIMA.Core.Search.Framework.Search;
using AIMA.Core.Search.Framework.SearchAgent;
using AIMA.Core.Search.Uninformed.IterativeDeepeningSearch;

public class IterativeDeepeningSearchTest {

	@Test
	public void testIterativeDeepeningSearch() {
		try {
			Problem problem = new Problem(new NQueensBoard(8),
					NQueensFunctionFactory.getIActionsFunction(),
					NQueensFunctionFactory.getResultFunction(),
					new NQueensGoalTest());
			Search search = new IterativeDeepeningSearch();
			SearchAgent agent = new SearchAgent(problem, search);
			List<Action> actions = agent.getActions();
			assertCorrectPlacement(actions);
			Assert.assertEquals("3656", agent.getInstrumentation().getProperty(
					"nodesExpanded"));

		} catch (Exception e) {
			e.printStackTrace();
			Assert.fail("Exception should not occur");
		}
	}

	private void assertCorrectPlacement(List<Action> actions) {
		Assert.assertEquals(8, actions.size());
		Assert.assertEquals(
				"Action[name==placeQueenAt, location== ( 0 , 0 ) ]", actions
						.get(0).ToString());
		Assert.assertEquals(
				"Action[name==placeQueenAt, location== ( 1 , 4 ) ]", actions
						.get(1).ToString());
		Assert.assertEquals(
				"Action[name==placeQueenAt, location== ( 2 , 7 ) ]", actions
						.get(2).ToString());
		Assert.assertEquals(
				"Action[name==placeQueenAt, location== ( 3 , 5 ) ]", actions
						.get(3).ToString());
		Assert.assertEquals(
				"Action[name==placeQueenAt, location== ( 4 , 2 ) ]", actions
						.get(4).ToString());
		Assert.assertEquals(
				"Action[name==placeQueenAt, location== ( 5 , 6 ) ]", actions
						.get(5).ToString());
		Assert.assertEquals(
				"Action[name==placeQueenAt, location== ( 6 , 1 ) ]", actions
						.get(6).ToString());
		Assert.assertEquals(
				"Action[name==placeQueenAt, location== ( 7 , 3 ) ]", actions
						.get(7).ToString());
	}
}