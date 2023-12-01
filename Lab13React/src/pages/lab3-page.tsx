import { CodeSnippet } from "src/components/code-snippet";
import LabForm from "src/components/lab-form";
import { PageLayout } from "src/components/page-layout";
import { useLabResult } from "src/hooks/useLabResult";

const Lab3Page: React.FC = () => {
  const { result, getResult } = useLabResult(3);

  return (
    <PageLayout>
      <div className="content-layout">
        <h1
          id="page-title"
          className="content__title"
        >
          Лабораторна робота 3
        </h1>
        <div className="content__body">
          <p>
            Можливо, деяким із вас знайома гра Zuma про пригоди жаби. У цьому завдання правила схожі
            і досить прості: у кам'яному жолобі знаходиться ряд різнокольорових куль; гармата, що
            розташувалася поруч із жолобом, має деякий запас різнокольорових кульок і періодично
            закидає їх у жолоб. Покинуті кулі вбудовуються в ряд. Якщо після пострілу в жолобі
            утворюється безперервна послідовність з трьох або більше куль одного кольору, що включає
            покинуту кулю, вони зникають, а сусідні кулі зсуваються, стуляючи ряд. Якщо після
            зникнення куль у місці стику присутні сусідні кулі (як ліворуч, так і праворуч), що
            утворюють безперервну послідовність з трьох або більше куль одного кольору, то вони
            також зникають, і так далі. Мета гри – знищити усі кулі.
          </p>
          <table>
            <thead>
              <tr>
                <th scope="col">Етап</th>
                <th scope="col">Малюнок</th>
                <th scope="col">Пояснення</th>
              </tr>
            </thead>
            <tbody>
              <tr>
                <th scope="row">1</th>
                <td>
                  <img
                    src="/images/img1.png"
                    alt="Image1"
                  />
                </td>
                <td>Вистрілюється нова куля «B», у позицію після кулі №1</td>
              </tr>
              <tr>
                <th scope="row">2</th>
                <td>
                  <img
                    src="/images/img2.png"
                    alt="Image2"
                  />
                </td>
                <td>
                  Після пострілу новий шар утворює із сусідніми послідовність кольору «B», в
                  позиціях 2-5. Довжина послідовності ≥3, тому кулі 2-5 зникнуть
                </td>
              </tr>
              <tr>
                <th scope="row">3</th>
                <td>
                  <img
                    src="/images/img3.png"
                    alt="Image3"
                  />
                </td>
                <td>Вистрілюється нова куля «B», у позицію після кулі №1</td>
              </tr>
            </tbody>
          </table>
          <p>
            Пронумеруємо кулі зліва направо, починаючи з одиниці. Постріл кулі в позицію n означає,
            що він з'явиться правіше за кулю з номером n і опиниться в позиції n+1. Номери куль,
            розташованих правіше кулі, що прилетіла, збільшуються на одиницю. Приземлення кулі
            ліворуч від ряду позначається позицією з номером 0. Після зникнення деяких куль, кулі в
            жолобі нумеруються заново зліва направо, починаючи з одиниці. Потрібно написати
            програму, яка визначає оптимальну стратегію стрільби. Оптимальною стратегією називається
            та, коли найменша кількість пострілів призводить до зникнення всіх куль.
          </p>
          <h3 className="content__title">Приклад файлу введення:</h3>
          <p id="page-description">
            <span>ACMNEERC</span>
          </p>
          <h3 className="content__title">Приклад файлу виведення:</h3>
          <p id="page-description">
            <span>10 A0 A0 C0 M2 M2 N2 N2 E2 R2 R2</span>
          </p>

          <LabForm submitHandler={getResult} />
          <CodeSnippet
            title="Результат:"
            code={result}
          />
        </div>
      </div>
    </PageLayout>
  );
};

export default Lab3Page;