import { CodeSnippet } from "src/components/code-snippet";
import LabForm from "src/components/lab-form";
import { PageLayout } from "src/components/page-layout";
import { useLabResult } from "src/hooks/useLabResult";

const Lab2Page: React.FC = () => {
  const { result, getResult } = useLabResult(2);

  return (
    <PageLayout>
      <div className="content-layout">
        <h1
          id="page-title"
          className="content__title"
        >
          Лабораторна робота 2
        </h1>
        <div className="content__body">
          <p id="page-description">
            <span>
              Розглянемо числову послідовність, що спочатку складається з двох одиниць: 1, 1. Далі
              на кожному наступному кроці вставлятимемо між сусідніми елементами їх суму. У прикладі
              елементи, що додаються, виділені:
            </span>
          </p>
          <table>
            <thead>
              <tr>
                <th scope="col">Номер кроку</th>
                <th scope="col">Послідовність</th>
              </tr>
            </thead>
            <tbody>
              <tr>
                <th scope="row">0</th>
                <td>1, 1</td>
              </tr>
              <tr>
                <th scope="row">1</th>
                <td>1, 2, 1</td>
              </tr>
              <tr>
                <th scope="row">2</th>
                <td>1, 3, 2, 3, 1</td>
              </tr>
              <tr>
                <th scope="row">3</th>
                <td>1, 4, 3, 5, 2, 5, 3, 4, 1</td>
              </tr>
            </tbody>
          </table>
          <p>
            Потрібно написати програму, яка підрахує суму членів послідовності, побудованої за K
            кроків.
          </p>
          <h3 className="content__title">Приклад файлу введення:</h3>
          <p id="page-description">
            <span>10</span>
          </p>
          <h3 className="content__title">Приклад файлу виведення:</h3>
          <p id="page-description">
            <span>59050</span>
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

export default Lab2Page;
