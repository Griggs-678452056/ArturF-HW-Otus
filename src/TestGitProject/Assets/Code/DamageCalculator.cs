using UnityEngine;

namespace Code
{
    public class DamageCalculator : MonoBehaviour
    {
        int baseDamage = 5;
        float multiplier = 1.5f;
        bool isTrue = true;

        private void Start()
        {
            Debug.Log($"Количество наносимого урона: {baseDamage}\nМножитель урона: {multiplier}\nНаносится ли урон? {isTrue}\n");
            float damage = CalculateDamage(baseDamage, multiplier);
            Debug.Log($"Итоговый урон: {damage}");
        }

        private float CalculateDamage(int baseDamage, float multiplier)
        {
            float result = baseDamage * multiplier;
            Debug.Log($"Расчёт урона: {baseDamage} * {multiplier} = {result}");
            return result;
        }
    }
}