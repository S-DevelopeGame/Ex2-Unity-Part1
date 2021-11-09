using UnityEngine;

/**
 * This component increases a given "score" field whenever it is triggered.
 */
public class ScoreAdder : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger adding score to the score field.")]
    [SerializeField] string[] triggeringTag;
    [SerializeField] NumberField scoreField;
    [SerializeField] int[] pointsToAdd;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag[0]) {
           
                scoreField.AddNumber(pointsToAdd[0]);
        }
        if (other.tag == triggeringTag[1])
        {

                scoreField.AddNumber(pointsToAdd[1]);
        }
    }

    public void SetScoreField(NumberField newTextField) {
        this.scoreField = newTextField;
    }
}
